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
                layoutTabChat.Text = "Account: " + Account;
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
            {
                if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
                {
                    XtraTabPage page = GetPageChat(boxOnline.SelectedItem.ToString());
                    page.PageVisible = true;
                    tabChat.SelectedTabPage = page;
                });
                else
                {
                    XtraTabPage page = GetPageChat(boxOnline.SelectedItem.ToString());
                    page.PageVisible = true;
                    tabChat.SelectedTabPage = page;
                }
            }
        }

        /// <summary>
        /// Event click close tab
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void TabChat_CloseButtonClick(object sender, EventArgs e)
        {
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                ((XtraTabPage)((ClosePageButtonEventArgs)e).Page).PageVisible = false;
            });
            else ((XtraTabPage)((ClosePageButtonEventArgs)e).Page).PageVisible = false;
        }

        /// <summary>
        /// Event button Send click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string message = textMessage.Text.Trim(new char[] { ' ', '\r', '\n', '\t' });
            while (message.Contains("\r\n\r\n")) message.Replace("\r\n\r\n", "\r\n");
            message.Replace("\r\n", "\r\n\t");

            if (tabChat.SelectedTabPageIndex >= 0 && message.Length > 0)
            {
                Send("chat|" + tabChat.SelectedTabPage.Text + "|" + message);
                ShowMessage("You", message, false);
            }
        }

        /// <summary>
        /// Show message in box chat
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="message">Message</param>
        /// <param name="receive">Message is receive or not?</param>
        private void ShowMessage(string name, string message, bool receive = true)
        {
            message += "\t\t";
            if (receive)
            {
                if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
                {
                    ((MemoEdit)GetPageChat(name).Controls[0]).Text += name + ":\r\n" + message + "\r\n";
                    GetPageChat(name).PageVisible = true;
                });
                else
                {
                    ((MemoEdit)GetPageChat(name).Controls[0]).Text += name + ":\r\n" + message + "\r\n";
                    GetPageChat(name).PageVisible = true;
                }
            }
            else
            {
                if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
                {
                    ((MemoEdit)tabChat.SelectedTabPage.Controls[0]).Text += name + ":\r\n" + message + "\r\n";
                    textMessage.Text = string.Empty;
                });
                else
                {
                    ((MemoEdit)tabChat.SelectedTabPage.Controls[0]).Text += name + ":\r\n" + message + "\r\n";
                    textMessage.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Add online client to list
        /// </summary>
        private void AddOnline(string name)
        {
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxOnline.Items.Add(name);
                XtraTabPage page = new XtraTabPage() { Text = name, PageVisible = false };
                page.Controls.Add(new MemoEdit() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, ReadOnly = true });
                tabChat.TabPages.Add(page);
            });
            else
            {
                boxOnline.Items.Add(name);
                XtraTabPage page = new XtraTabPage() { Text = name, PageVisible = false };
                page.Controls.Add(new MemoEdit() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, ReadOnly = true });
                tabChat.TabPages.Add(page);
            }
        }

        /// <summary>
        /// Remove online client to list
        /// </summary>
        private void RemoveOnline(string name)
        {
            if (InvokeRequired) BeginInvoke((MethodInvoker)delegate ()
            {
                boxOnline.Items.Remove(name);
                GetPageChat(name).PageVisible = false;
            });
            else
            {
                boxOnline.Items.Remove(name);
                GetPageChat(name).PageVisible = false;
            }
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
            IPEndPoint server = new IPEndPoint(Data.Config.IP, Data.Config.Port);
            SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                connected = true;
                SocketClient.Connect(server);
            }
            catch
            {
                CloseClient("Could not connect to server");
            }

            Thread listen = new Thread(Receive) { IsBackground = true };
            listen.Start();

            Send("connect|" + Account);
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
                CloseClient("Could not connect to server");
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
                CloseClient("Could not connect to server");
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
                    AddOnline(tokens[1]);
                    break;

                case "list":
                    for (int i = 1; i < tokens.Length; i++) AddOnline(tokens[i]);
                    break;

                case "chat":
                    ShowMessage(tokens[1], message.Remove(0, (tokens[0] + "|" + tokens[1] + "|").Length));
                    System.Media.SystemSounds.Hand.Play();
                    break;

                case "disconnect":
                    if (tokens[1] == Account) CloseClient("You are kicked by administrator!");
                    else RemoveOnline(tokens[1]);
                    break;
            }
        }

        /// <summary>
        /// Close client if could not connect to server
        /// </summary>
        private void CloseClient(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
