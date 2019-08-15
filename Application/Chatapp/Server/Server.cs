using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : XtraForm
    {
        #region Properties
        /// <summary>
        /// Account login server
        /// </summary>
        private static string account;

        /// <summary>
        /// List of clients connected
        /// </summary>
        private List<Client> clients;

        /// <summary>
        /// Is server alive ?
        /// </summary>
        private bool alive;

        /// <summary>
        /// Socket server
        /// </summary>
        private Socket socketServer;
        #endregion

        #region Constructors
        /// <summary>
        /// Server constructor
        /// </summary>
        public Server()
        {
            InitializeComponent();
            Icon = Properties.Resources.ServerIcon;
            account = null;
            clients = new List<Client>();
            alive = false;
        }
        #endregion

        #region Events
        /// <summary>
        /// Event server has shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void Server_Shown(object sender, EventArgs e)
        {
            using (Login login = new Login()) { login.ShowDialog(); }
            if (Account == null) Application.Exit();
            else
            {
                Cmd("Hello " + account + ", wellcome to Chatapp!");
                Cmd("Preparing to start server...");
                Start();
            }
        }

        /// <summary>
        /// Event server is closing
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Ảgs</param>
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Account != null) Data.Account.Instance.Logout(Account, 1);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Startup server
        /// </summary>
        private void Start()
        {
            IPEndPoint client = new IPEndPoint(IPAddress.Any, Data.Config.Port);
            SocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            alive = true;

            SocketServer.Bind(client);
            Thread listener = new Thread(Listen) { IsBackground = true };
            try
            {
                Cmd("Listening...");
                listener.Start();
            }
            catch
            {
                alive = false;
                listener.Abort();
                Application.Exit();
            }
        }

        /// <summary>
        /// Listen to client
        /// </summary>
        private void Listen()
        {
            while (alive)
            {
                SocketServer.Listen(100);
                Client client = new Client(SocketServer.Accept());
                clients.Add(client);
                Cmd(client + " : Request to connect");

                Thread servicer = new Thread(() => Receive(client)) { IsBackground = true };
                servicer.Start();
            }
        }

        /// <summary>
        /// Receive message from client
        /// </summary>
        /// <param name="client">Receive from which client?</param>
        private void Receive(Client client)
        {
            try
            {
                while (alive)
                {
                    byte[] data = new byte[5120];
                    client.Socket.Receive(data);
                    string message = Data.Message.Deserialize(data);
                    boxMess.Items.Add(client.Socket.RemoteEndPoint + " --> " + message.Trim('\0'));

                    Analyze(client, message);
                }
            }
            catch
            {
                Cmd(client + " : Disconnect");
                clients.Remove(client);
                clients.ForEach(e => Send(e, "disconnect|" + client.Account));
                boxClients.Items.Remove(client);
                client.Close();
            }
        }

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="client">Send to which client?</param>
        /// <param name="message">Message</param>
        private void Send(Client client, string message)
        {
            try
            {
                if (alive)
                {
                    client.Socket.Send(Data.Message.Serialize(message));
                    boxMess.Items.Add(client.Socket.RemoteEndPoint + " <-- " + message);
                }
            }
            catch
            {
                Cmd(client + " : Disconnect");                
                clients.Remove(client);
                clients.ForEach(e => Send(e, "disconnect|" + client.Account));
                boxClients.Items.Remove(client);
                client.Close();

            }
        }

        /// <summary>
        /// Analyze message
        /// </summary>
        /// <param name="client">Receive from which client</param>
        /// <param name="message">Message</param>
        private void Analyze(Client client, string message)
        {
            string[] tokens = message.Trim('\0').Split('|');
            switch (tokens[0])
            {
                case "connect":
                    Send(client, "list" + Clients());
                    client.Account = tokens[1];
                    boxClients.Items.Add(client);
                    Cmd(client + " : Accept and send list clients");
                    break;
            }
        }

        /// <summary>
        /// Return list clients to string
        /// </summary>
        /// <returns></returns>
        private string Clients()
        {
            string result = "";
            clients.ForEach(client => result += "|" + client.Account);
            return result;
        }

        /// <summary>
        /// Writeln in cmdbox
        /// </summary>
        /// <param name="cmd">Command</param>
        private void Cmd(string cmd)
        {
            boxCmd.Items.Add(cmd);
        }
        #endregion

        #region Getter Setter
        /// <summary>
        /// Account login
        /// </summary>
        public static string Account { get => account; set => account = value; }
        /// <summary>
        /// Socket server
        /// </summary>
        public Socket SocketServer { get => socketServer; set => socketServer = value; }
        #endregion
    }


    /// <summary>
    /// Client class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// account client login
        /// </summary>
        private string account;

        /// <summary>
        /// socket client
        /// </summary>
        private Socket socket;

        /// <summary>
        /// Client constructor
        /// </summary>
        /// <param name="socket">Socket client</param>
        public Client(Socket socket) { account = null; Socket = socket; }

        /// <summary>
        /// Close connect client
        /// </summary>
        public void Close() { Socket.Close(); }

        /// <summary>
        /// Return string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Socket.RemoteEndPoint.ToString() + ((Account != null) ? (" - " + Account) : "");
        }

        /// <summary>
        /// Account client login
        /// </summary>
        public string Account { get => account; set => account = value; }

        /// <summary>
        /// Socket client
        /// </summary>
        public Socket Socket { get => socket; set => socket = value; }
    }
}
