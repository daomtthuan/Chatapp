using Chatapp.bll;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Chatapp.ui
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
                BllClient.Instance.Client.Login(nameTextEdit.Text, passwordTextEdit.Text);
            }
        }

        public void Alert()
        {
            if (BllClient.Instance.Client.Connect)
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