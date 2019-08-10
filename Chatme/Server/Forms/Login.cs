using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Server.Forms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textAdministrator.Text.ToLower() == "admin" && textPassword.Text == "1")
            {
                Hide();
                new Server().ShowDialog();
                Show();
            }
            else
            {
                XtraMessageBox.Show("Couldn't log in to Chatme Server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}