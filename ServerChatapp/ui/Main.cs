using System;
using System.Windows.Forms;
using ServerChatapp.bll;

namespace ServerChatapp.ui
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using(Login login = new Login())
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
    }
}