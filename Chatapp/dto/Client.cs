using Chatapp.bll;
using Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Chatapp.dto
{
    public class Client
    {
        private Account account;
        private IPEndPoint server;
        private Socket socket;
        private bool alive;
        private bool connect;
        private List<string> onlines;

        public Client()
        {
            Alive = false;
            Connect = false;
        }

        public Account Account { get => account; private set => account = value; }
        public IPEndPoint Server { get => server; private set => server = value; }
        public Socket Socket { get => socket; private set => socket = value; }
        public bool Alive { get => alive; private set => alive = value; }
        public bool Connect { get => connect; private set => connect = value; }
        public List<string> Onlines { get => onlines; private set => onlines = value; }

        public void Start()
        {
            Server = new IPEndPoint
            (
                (
                ConfigurationManager.AppSettings.Get("IP").Length == 0) ?
                    Dns.GetHostAddresses(Dns.GetHostName())[1] :
                    IPAddress.Parse(ConfigurationManager.AppSettings.Get("IP")
                ),
                Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port"))
            );
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                Socket.Connect(Server);
                Alive = true;
            }
            catch
            {
                XtraMessageBox.Show("Could not connect to server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alive = false;
                Connect = false;
                Application.Exit();
            }

            Thread receiver = new Thread(Receive) { IsBackground = true };
            receiver.Start();
        }

        public void Login(string name, string password)
        {
            Account = new Account(name);
            Send("login|" + name + "|" + password);
        }

        private void Receive()
        {
            try
            {
                while (Alive)
                {
                    byte[] data = new byte[5120];
                    Socket.Receive(data);
                    string message = Encode.Deserialize(data);
                    Analyze(message);
                }
            }
            catch
            {
                XtraMessageBox.Show("Could not connect to server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alive = false;
                Connect = false;
                Application.Exit();
            }
        }

        public void Send(string message)
        {
            try
            {
                if (Alive)
                {
                    Socket.Send(Encode.Serialize(message));
                }
            }
            catch
            {
                XtraMessageBox.Show("Could not connect to server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alive = false;
                Connect = false;
                Application.Exit();
            }
        }

        private void Analyze(string message)
        {
            message = message.Trim('\0');
            string[] tokens = message.Split('|');
            switch (tokens[0])
            {
                case "login":
                    if (tokens[1] == "success")
                    {
                        Onlines = new List<string>();
                        for (int i = 2; i < tokens.Length; i++)
                        {
                            Onlines.Add(tokens[i]);
                            BllClient.Instance.Main.AddOnline(tokens[i]);
                        }
                        Connect = true;
                    }
                    BllClient.Instance.Login.Alert();
                    break;

                case "connect":
                    Onlines.Add(tokens[1]);
                    BllClient.Instance.Main.AddOnline(tokens[1]);
                    break;

                case "disconnect":
                    Onlines.Remove(tokens[1]);
                    BllClient.Instance.Main.RemoveOnline(tokens[1]);
                    break;

                case "chat":
                    BllClient.Instance.Main.ShowMessage(tokens[1], message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length));
                    System.Media.SystemSounds.Hand.Play();
                    break;
            }
        }

        public void Stop()
        {
            Send("logout|");
            if (Socket != null)
            {
                Socket.Close();
                Socket.Dispose();
            }
        }
    }
}
