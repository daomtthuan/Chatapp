using Chatapp.bll;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Windows.Forms;

namespace Chatapp.ui
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
            BllClient.Instance.Client.Start();
            BllClient.Instance.Login = new Login();
            BllClient.Instance.Login.ShowDialog();
            if (BllClient.Instance.Client.Connect)
            {
            }
            else
            {
                Application.Exit();
            }
        }

        public void AddOnline(string name)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    onlineListBoxControl.Items.Add(name);
                    XtraTabPage page = new XtraTabPage() { Text = name, PageVisible = false };
                    page.Controls.Add(new MemoEdit() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, ReadOnly = true });
                    tabControl.TabPages.Add(page);
                }));
            }
            else
            {
                onlineListBoxControl.Items.Add(name);
                XtraTabPage page = new XtraTabPage() { Text = name, PageVisible = false };
                page.Controls.Add(new MemoEdit() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, ReadOnly = true });
                tabControl.TabPages.Add(page);
            }
        }

        public void RemoveOnline(string name)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    onlineListBoxControl.Items.Remove(name);
                    GetPageChat(name).PageVisible = false;
                }));
            }
            else
            {
                onlineListBoxControl.Items.Remove(name);
                GetPageChat(name).PageVisible = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            BllClient.Instance.Client.Stop();
            GC.Collect();
        }

        private XtraTabPage GetPageChat(string name)
        {
            foreach (XtraTabPage page in tabControl.TabPages)
                if (page.Text == name) return page;
            return null;
        }

        private void OnlineListBoxControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (onlineListBoxControl.IndexFromPoint(e.Location) >= 0)
            {
                if (InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {
                        XtraTabPage page = GetPageChat(onlineListBoxControl.SelectedItem.ToString());
                        page.PageVisible = true;
                        tabControl.SelectedTabPage = page;
                    }));
                }
                else
                {
                    XtraTabPage page = GetPageChat(onlineListBoxControl.SelectedItem.ToString());
                    page.PageVisible = true;
                    tabControl.SelectedTabPage = page;
                }
            }
        }

        private void TabControl_CloseButtonClick(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    ((XtraTabPage)((ClosePageButtonEventArgs)e).Page).PageVisible = false;
                }));
            }
            else
            {
                ((XtraTabPage)((ClosePageButtonEventArgs)e).Page).PageVisible = false;
            }
        }

        private void SendSimpleButton_Click(object sender, EventArgs e)
        {
            string message = messageTextEdit.Text.Trim();
            if (tabControl.SelectedTabPageIndex >= 0 && message.Length > 0)
            {
                BllClient.Instance.Client.Send("chat|" + tabControl.SelectedTabPage.Text + "|" + message);
                ShowMessage("You", message, false);
            }
        }

        public void ShowMessage(string name, string message, bool receive = true)
        {
            if (receive)
            {
                if (InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {
                        ((MemoEdit)GetPageChat(name).Controls[0]).Text += name + ":\r\n    " + message + "\r\n";
                        GetPageChat(name).PageVisible = true;
                    }));
                }
                else
                {
                    ((MemoEdit)GetPageChat(name).Controls[0]).Text += name + ":\r\n    " + message + "\r\n";
                    GetPageChat(name).PageVisible = true;
                }
            }
            else
            {
                if (InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {
                        ((MemoEdit)tabControl.SelectedTabPage.Controls[0]).Text += name + ":\r\n    " + message + "\r\n";
                        messageTextEdit.Text = string.Empty;
                    }));
                }
                else
                {
                    ((MemoEdit)tabControl.SelectedTabPage.Controls[0]).Text += name + ":\r\n    " + message + "\r\n";
                    messageTextEdit.Text = string.Empty;
                }
            }
        }
    }
}