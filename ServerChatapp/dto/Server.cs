using ServerChatapp.dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace ServerChatapp.dto
{
    public class Server
    {
        private Account account;
        private Socket socket;
        private bool alive;
        private List<Client> clients;

        public Server()
        {
            Alive = false;
        }

        public Account Account { get => account; private set => account = value; }
        public Socket Socket { get => socket; private set => socket = value; }
        public bool Alive { get => alive; private set => alive = value; }
        public List<Client> Clients { get => clients; private set => clients = value; }

        public void Start(Account account)
        {         
            Console.WriteLine("Hello " + account + ", wellcome to Server Chatapp!");
            Console.WriteLine("Preparing to start server...");

            Account = account;            
            Clients = new List<Client>();
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Alive = true;

            IPEndPoint client = new IPEndPoint(IPAddress.Any, Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port")));
            Socket.Bind(client);

            Console.WriteLine("Listening...");
            Thread listener = new Thread(Listen) { IsBackground = true };
            listener.Start();
        }

        private void Listen()
        {
            try
            {
                while (Alive)
                {
                    Socket.Listen(100);
                    Client client = new Client(Socket.Accept());
                    Clients.Add(client);
                    Console.WriteLine(client.Address + " has connected");

                    Console.WriteLine("Run service for " + client.Address);
                    Thread servicer = new Thread(() => Receive(client)) { IsBackground = true };
                    servicer.Start();
                }
            }
            catch
            {
                Alive = false;
                Application.Exit();
            }
        }

        private void Receive(Client client)
        {
            try
            {
                while (Alive)
                {
                    byte[] data = new byte[5120];
                    client.Socket.Receive(data);
                    string message = Deserialize(data);
                    Console.WriteLine("From " + client + ": " + message.Trim('\0').Replace("\r\n", "\\r\\n"));
                    Analyze(client, message);
                }
            }
            catch
            {
                Disconnect(client);
            }
        }

        private static byte[] Serialize(string message)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, message);
            return stream.ToArray();
        }

        /// <summary>
        /// Deserialize tokens byte to message
        /// </summary>
        /// <param name="tokens">Tokens of received message</param>
        /// <returns>String message</returns>
        private static string Deserialize(byte[] tokens)
        {
            MemoryStream stream = new MemoryStream(tokens);
            BinaryFormatter formatter = new BinaryFormatter();
            return (string)formatter.Deserialize(stream);
        }

        private void Analyze(Client client, string message)
        {
            message = message.Trim('\0');
            string[] tokens = message.Split('|');
            switch (tokens[0])
            {
                case "login":
                    string name = tokens[1];
                    string password = tokens[2];
                    if (DalAccount.Instance.Login(name, password, 0))
                    {
                        client.Account = new Account(name);
                        Send(client, "login|success");
                    }
                    break;
                //case "connect":
                //    client.Account = tokens[1];
                //    Command(client.Address + " : Connected");
                //    AddClients(client);

                //    Command(client.Address + " : Send list clients");
                //    string list = "";
                //    for (int i = 0; i < Clients.Count - 1; i++)
                //    {
                //        list += "|" + Clients[i].Account;
                //        Send(Clients[i], "connect|" + client.Account);
                //    }
                //    Send(client, "list" + list);
                //    break;

                //case "chat":
                //    foreach (Client element in Clients)
                //        if (element.Account == tokens[1])
                //        {
                //            Send(element, "chat|" + client.Account + "|" + message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length));
                //            break;
                //        }
                //    break;
            }
        }

        private void Send(Client client, string message)
        {
            try
            {
                if (Alive)
                {
                    client.Socket.Send(Serialize(message));
                    Console.WriteLine("To " + client + ": " + message.Replace("\r\n", "\\r\\n"));
                }
            }
            catch
            {
                Disconnect(client);
            }
        }

        private void Disconnect(Client client)
        {
            //Console.WriteLine(client.Address + " : has disconnected");
            //Clients.Remove(client);
            //Clients.ForEach(e => Send(e, "disconnect|" + client.Account));

            //if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            //{
            //    boxClients.Items.Remove(client);
            //    client.Close();
            //});
            //else
            //{
            //    boxClients.Items.Remove(client);
            //    client.Close();
            //}
        }
    }
}