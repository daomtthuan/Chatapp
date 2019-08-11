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

namespace Server.Forms
{
    public partial class Server : DevExpress.XtraEditors.XtraForm
    {
        public Server(string administrator)
        {
            InitializeComponent();

            labelAdministrator.Text += administrator;
        }
    }
}