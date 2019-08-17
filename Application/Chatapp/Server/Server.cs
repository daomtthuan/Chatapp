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
        /// List Clients
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
            CheckForIllegalCrossThreadCalls = false;
            account = null;
            Clients = new List<Client>();
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
                Command("Hello " + account + ", wellcome to Chatapp server!");
                Command("Preparing to start server...");
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

        /// <summary>
        /// Event click button disconnect
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            clients.ForEach(client => Send(client, "disconnect|" + Clients[boxClients.SelectedIndex].Account));
        }

        /// <summary>
        /// Event click button disconnect all
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void ButtonDisconnectAll_Click(object sender, EventArgs e)
        {
            clients.ForEach(client => Send(client, "disconnect|" + client.Account));
        }

        /// <summary>
        /// Event Selected index changed boxClients
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void BoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDisconnect.Enabled = boxClients.SelectedIndex >= 0;
            buttonDisconnectAll.Enabled = Clients.Count > 0;
        }

        /// <summary>
        /// Writeline command
        /// </summary>
        /// <param name="command">Command</param>
        private void Command(string command)
        {
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxCommand.Text += command + "\r\n";
            });
            else boxCommand.Text += command + "\r\n";
        }

        /// <summary>
        /// Writeline message
        /// </summary>
        /// <param name="message">Message</param>
        private void Message(string message)
        {
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxMessage.Text += message + "\r\n";
            });
            else boxMessage.Text += message + "\r\n";
        }

        /// <summary>
        /// Add connected clients
        /// </summary>
        /// <param name="client">Client</param>
        private void AddClients(Client client)
        {
            Clients.Add(client);
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxClients.Items.Add(client);
            });
            else boxClients.Items.Add(client);
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
            Command("Listening...");

            Thread listener = new Thread(Listen) { IsBackground = true };
            listener.Start();
        }

        /// <summary>
        /// Listen to client
        /// </summary>
        private void Listen()
        {
            try
            {
                while (alive)
                {
                    SocketServer.Listen(100);
                    Client client = new Client(SocketServer.Accept());
                    Command(client.Address + " : Request to connect");

                    Thread servicer = new Thread(() => Receive(client)) { IsBackground = true };
                    servicer.Start();
                }
            }
            catch
            {
                alive = false;
                Application.Exit();
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
                    Message(client.Socket.RemoteEndPoint + " --> " + message.Trim('\0').Replace("\r\n", "\\r\\n"));

                    Analyze(client, message);
                }
            }
            catch
            {
                CloseConnect(client);
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
                    Message(client.Socket.RemoteEndPoint + " <-- " + message.Replace("\r\n", "\\r\\n"));
                }
            }
            catch
            {
                CloseConnect(client);
            }
        }

        /// <summary>
        /// Analyze message
        /// </summary>
        /// <param name="client">Receive from which client</param>
        /// <param name="message">Message</param>
        private void Analyze(Client client, string message)
        {
            message = message.Trim('\0');
            string[] tokens = message.Split('|');
            switch (tokens[0])
            {
                case "connect":
                    client.Account = tokens[1];
                    Command(client.Address + " : Connected");
                    AddClients(client);

                    Command(client.Address + " : Send list clients");
                    string list = "";
                    for (int i = 0; i < Clients.Count - 1; i++)
                    {
                        list += "|" + Clients[i].Account;
                        Send(Clients[i], "connect|" + client.Account);
                    }
                    Send(client, "list" + list);
                    break;

                case "chat":
                    foreach (Client element in Clients)
                        if (element.Account == tokens[1])
                        {
                            Send(element, "chat|" + client.Account + "|" + message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length));
                            break;
                        }
                    break;
            }
        }

        /// <summary>
        /// Disconnected to client
        /// </summary>
        /// <param name="client">Client</param>
        private void CloseConnect(Client client)
        {
            Command(client.Address + " : Disconnected");
            Clients.Remove(client);
            Clients.ForEach(e => Send(e, "disconnect|" + client.Account));

            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxClients.Items.Remove(client);
                client.Close();
            });
            else
            {
                boxClients.Items.Remove(client);
                client.Close();
            }            
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

        /// <summary>
        /// List Clients
        /// </summary>
        public List<Client> Clients { get => clients; set => clients = value; }
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
        public void Close()
        {
            Socket.Close();
        }

        /// <summary>
        /// Return string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Socket.RemoteEndPoint.ToString() + ((Account != null) ? (" - " + Account) : "");
        }

        /// <summary>
        /// Get client's address
        /// </summary>
        /// <returns></returns>
        public string Address { get => socket.RemoteEndPoint.ToString(); }

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
