using DevExpress.XtraEditors;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    /// <summary>
    /// Form client
    /// </summary>
    public partial class Client : XtraForm
    {
        #region Properties
        /// <summary>
        /// Account login
        /// </summary>
        private static string account;

        /// <summary>
        /// Client is still connecting to server?
        /// </summary>
        private bool connected;

        /// <summary>
        /// Socket client
        /// </summary>
        private Socket socketClient;
        #endregion

        #region Constructor
        /// <summary>
        /// Client constructor
        /// </summary>
        public Client()
        {
            InitializeComponent();
            Icon = Properties.Resources.ClientIcon;
            connected = false;
        }
        #endregion

        #region Events
        /// <summary>
        /// Event form has shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void Client_Shown(object sender, EventArgs e)
        {
            using (Login login = new Login()) { login.ShowDialog(); }
            if (Account == null) Application.Exit();
            else Connect();
        }

        /// <summary>
        /// Event client is closing
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Account != null)
            {
                Data.Account.Instance.Logout(Account, 0);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Connect to server
        /// </summary>
        private void Connect()
        {
            IPEndPoint server = new IPEndPoint(IPAddress.Parse(Data.Config.IP), Data.Config.Port);
            SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                connected = true;
                SocketClient.Connect(server);
            }
            catch
            {
                CloseClient();
            }

            Thread listen = new Thread(Receive) { IsBackground = true };
            listen.Start();

            Send("connect|" + account);
        }

        /// <summary>
        /// Send message to server
        /// </summary>
        /// <param name="message"></param>
        private void Send(string message)
        {
            try
            {
                if (connected) SocketClient.Send(Data.Message.Serialize(message));
            }
            catch
            {
                CloseClient();
            }
        }

        /// <summary>
        /// Receive message from server
        /// </summary>
        private void Receive()
        {
            try
            {
                while (connected)
                {
                    byte[] data = new byte[5120];
                    SocketClient.Receive(data);
                    string message = Data.Message.Deserialize(data);

                    Analyze(message);
                }
            }
            catch
            {
                CloseClient();
            }
        }

        /// <summary>
        /// Analyze message from server
        /// </summary>
        /// <param name="message">Message</param>
        private void Analyze(string message)
        {
            string[] tokens = message.Trim('\0').Split('|');
            switch (tokens[0])
            {
                case "list":
                    MessageBox.Show("Hahahaha");
                    break;
            }
        }

        /// <summary>
        /// Close client if could not connect to server
        /// </summary>
        private void CloseClient()
        {
            MessageBox.Show("Could not connect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            connected = false;
            SocketClient.Close();
            Application.Exit();
        }
        #endregion

        #region Getter Setter
        /// <summary>
        /// Account login
        /// </summary>
        public static string Account { get => account; set => account = value; }

        /// <summary>
        /// Socket client
        /// </summary>
        public Socket SocketClient { get => socketClient; set => socketClient = value; }
        #endregion
    }
}
