using DevExpress.XtraEditors;
using System;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Chatapp.dto
{
    public class Client
    {
        private Account account;
        private Socket socket;
        private bool connect;        

        public Client()
        {
            Connect = false;            
        }      

        public Account Account { get => account; private set => account = value; }
        public Socket Socket { get => socket; private set => socket = value; }
        public bool Connect { get => connect; private set => connect = value; }

        public void Start()
        {
            IPEndPoint server = new IPEndPoint
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
                Socket.Connect(server);
            }
            catch
            {
                Close("Could not connect to server");
            }
        }

        private void Close(string message)
        {
            XtraMessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Connect = false;
            Socket.Close();
            Application.Exit();
        }
    }
}
