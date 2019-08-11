using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Client.Objects;

namespace Client.Forms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        #region Constructors
        /// <summary>
        /// Constructor Login form
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Event Click button Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Substring(0, 1).ToUpper() + textUsername.Text.Substring(1).ToLower();
            string password = textPassword.Text;
            if (User.Login(username, password))
            {
                Hide();
                textUsername.Text = "";
                textPassword.Text = "";
                textUsername.Select();
                new Client(username).ShowDialog();
                Show();
            }
            else
            {
                XtraMessageBox.Show("Couldn't log in to Chatme", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}