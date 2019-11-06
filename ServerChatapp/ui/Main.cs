using ServerChatapp.bll;
using ServerChatapp.dto;
using System;
using System.Windows.Forms;

namespace ServerChatapp.ui
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                login.ShowDialog();
                if (BllServer.Instance.Server.Alive)
                {
                    Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public void AddClient(Client client)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    clientListBoxControl.Items.Add(client);
                }));
            }
            else
            {
                clientListBoxControl.Items.Add(client);
            }
        }

        public void RemoveClient(Client client)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    clientListBoxControl.Items.Remove(client);
                }));
            }
            else
            {
                clientListBoxControl.Items.Remove(client);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            BllServer.Instance.Server.Stop();
            GC.Collect();
        }
    }
}