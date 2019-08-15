using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    /// <summary>
    /// Form client
    /// </summary>
    public partial class Client : DevExpress.XtraEditors.XtraForm
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
        private Socket client;
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
            Data.Account.Instance.Logout("admin", 1);
            using (Login login = new Login()) { login.ShowDialog(); }
            if (Account == null) Application.Exit();
            else
            {
                Connect();
            }
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
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                connected = true;
                client.Connect(server);
                Send("connect|" + account);
            }
            catch
            {
                connected = false;
                client.Close();
                Application.Exit();
            }
        }

        private void Send(string message)
        {
            try
            {
                if (connected) client.Send(Data.Message.Serialize(message));
            }
            catch
            {
                connected = false;
                client.Close();
                Application.Exit();
            }
        }
        #endregion

        #region Getter Setter
        /// <summary>
        /// Account login
        /// </summary>
        public static string Account { get => account; set => account = value; }
        #endregion
    }
}
