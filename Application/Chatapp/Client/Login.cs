using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Client
{

    /// <summary>
    /// Form login client
    /// </summary>
    public partial class Login : XtraForm
    {
        #region Constructor
        /// <summary>
        /// Login constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Event button login click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textName.Text.Length == 0 || textPassword.Text.Length == 0)
                XtraMessageBox.Show("Enter account to login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string account = Data.Account.Instance.Login(textName.Text, textPassword.Text, 0);
                if (account == null)
                    XtraMessageBox.Show("Could not login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Client.Account = account;
                    Close();
                }
            }
        }
        #endregion
    }
}