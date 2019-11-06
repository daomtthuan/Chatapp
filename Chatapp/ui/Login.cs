using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Chatapp.ui
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text.Length + passwordTextEdit.Text.Length == 0)
            {
                XtraMessageBox.Show("Enter account to login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
        }
    }
}