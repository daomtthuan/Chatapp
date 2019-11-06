using Chatapp.bll;
using System;
using System.Windows.Forms;

namespace Chatapp.ui
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
            BllClient.Instance.Client.Start();

            using (Login login = new Login())
            {
                login.ShowDialog();
                if (BllClient.Instance.Client.Connect)
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