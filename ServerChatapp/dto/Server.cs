using Data;
using ServerChatapp.bll;
using ServerChatapp.dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
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
            Console.WriteLine("Preparing to start server...\n");

            Account = account;
            Clients = new List<Client>();
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Alive = true;

            IPEndPoint client = new IPEndPoint(IPAddress.Any, Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port")));
            Socket.Bind(client);

            Console.WriteLine("Listening...\n");
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
                    Console.WriteLine(client.Socket.RemoteEndPoint + " has connected");

                    Console.WriteLine("Run service for " + client.Socket.RemoteEndPoint + "\n");
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
                while (Alive && client.Connect)
                {
                    byte[] data = new byte[5120];
                    client.Socket.Receive(data);
                    string message = Encode.Deserialize(data);
                    Console.WriteLine("From " + client + ": " + message.Trim('\0'));
                    Analyze(client, message);
                }
            }
            catch
            {
                Disconnect(client);
            }
        }

        private void Analyze(Client client, string message)
        {
            message = message.Trim('\0');
            string[] tokens = message.Split('|');
            switch (tokens[0])
            {
                case "login":
                    if (DalAccount.Instance.Login(tokens[1], tokens[2], 0))
                    {
                        client.Account = new Account(tokens[1]);
                        string send = "login|success";
                        Clients.ForEach(element =>
                        {
                            send += "|" + element.Account.Name;
                            Send(element, "connect|" + client.Account.Name);
                        });
                        Send(client, send);
                        Clients.Add(client);
                        BllServer.Instance.Main.AddClient(client);
                    }
                    else
                    {
                        Send(client, "login|fail");
                    }
                    break;

                case "logout":
                    Disconnect(client);
                    break;

                case "chat":
                    Clients.ForEach(element =>
                    {
                        if (element.Account.Name == tokens[1])
                        {
                            Send(element, "chat|" + client.Account.Name + "|" + message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length));
                            return;
                        }
                    });
                    break;
            }
            Console.WriteLine();
        }

        private void Send(Client client, string message)
        {
            try
            {
                if (Alive && client.Connect)
                {
                    client.Socket.Send(Encode.Serialize(message));
                    Console.WriteLine("To " + client + ": " + message);
                }
            }
            catch
            {
                Disconnect(client);
            }
        }

        private void Disconnect(Client client)
        {
            Console.WriteLine(client + " : has disconnected\n");            
            if (client.Account != null)
            {
                Clients.Remove(client);
                BllServer.Instance.Main.RemoveClient(client);
                DalAccount.Instance.Logout(client.Account.Name);
                Clients.ForEach(e => Send(e, "disconnect|" + client.Account.Name));
            }            
            client.Close();
        }

        public void Stop()
        {
            if (Account != null)
            {
                DalAccount.Instance.Logout(Account.Name);
            }
            if (Socket != null)
            {
                Socket.Close();
                Socket.Dispose();
            }
        }
    }
}