using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
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
            CheckForIllegalCrossThreadCalls = false;
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
            else
            {
                Connect();
                layoutTabChat.Text = "Account: " + account;
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

        /// <summary>
        /// Event box online mouse click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void BoxOnline_MouseClick(object sender, MouseEventArgs e)
        {
            if (boxOnline.IndexFromPoint(e.Location) >= 0)
                GetPageChat(boxOnline.SelectedItem.ToString()).PageVisible = true;
        }

        /// <summary>
        /// Event click close tab
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void TabChat_CloseButtonClick(object sender, EventArgs e)
        {
            ((XtraTabPage)((ClosePageButtonEventArgs)e).Page).PageVisible = false;
        }

        /// <summary>
        /// Event button Send click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string message = textMessage.Text.Trim(new char[] { ' ', '\r', '\n', });
            while (message.Contains("\r\n\r\n")) message.Replace("\r\n\r\n", "\r\n");

            if (tabChat.TabPages.Count > 0 && message.Length > 0)
            {
                Send("chat|" + tabChat.SelectedTabPage.Text + "|" + message);
                ((MemoEdit)tabChat.SelectedTabPage.Controls[0]).Text += "You:\r\n" + message + "\r\n\r\n";
            }
            textMessage.Text = string.Empty;
        }

        /// <summary>
        /// Add page into tab chat
        /// </summary>
        /// <param name="name">Name page</param>
        private void AddPageChat(string name)
        {
            XtraTabPage page = new XtraTabPage { Text = name, PageVisible = false };
            page.Controls.Add(new MemoEdit() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, ReadOnly = true });
            tabChat.TabPages.Add(page);
        }

        /// <summary>
        /// Get page chat in tab by name
        /// </summary>
        /// <param name="name">Name page</param>
        /// <returns></returns>
        private XtraTabPage GetPageChat(string name)
        {
            foreach (XtraTabPage page in tabChat.TabPages)
                if (page.Text == name) return page;
            return null;
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
            message = message.Trim('\0');
            string[] tokens = message.Split('|');
            switch (tokens[0])
            {
                case "connect":
                    boxOnline.Items.Add(tokens[1]);
                    break;

                case "list":
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        boxOnline.Items.Add(tokens[i]);
                        AddPageChat(tokens[i]);
                    }
                    break;

                case "chat":
                    message = message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length);
                    string name = tokens[1];                    
                    ((MemoEdit)GetPageChat(name).Controls[0]).Text += name + ":\r\n" + message + "\r\n\r\n";
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
