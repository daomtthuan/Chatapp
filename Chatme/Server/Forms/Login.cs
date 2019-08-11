using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Server.Objects;

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
            string administrator = textAdministrator.Text.Substring(0, 1).ToUpper() + textAdministrator.Text.Substring(1).ToLower();
            string password = textPassword.Text;
            if (Administrator.Login(administrator, password))
            {
                Hide();
                textAdministrator.Text = "";
                textPassword.Text = "";
                textAdministrator.Select();
                new Server(administrator).ShowDialog();
                Show();
            }
            else
            {
                XtraMessageBox.Show("Couldn't log in to Chatme Server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}