using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : XtraForm
    {
        public static readonly string Account;

        public Server()
        {
            InitializeComponent();
        //    Icon = Data.Config.ServerIcon;     
            (new Login()).ShowDialog();


        }
    }
}
