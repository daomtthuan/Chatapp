using DevExpress.XtraEditors;
using ServerChatapp.bll;
using System;
using System.Windows.Forms;

namespace ServerChatapp.ui
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text.Length + passwordTextEdit.Text.Length == 0)
            {
                XtraMessageBox.Show("Enter account to login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BllServer.Instance.Login(nameTextEdit.Text, passwordTextEdit.Text);
                if (BllServer.Instance.Server.Alive)
                {
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Could not login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}