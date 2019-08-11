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
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace Client.Forms
{
    public partial class Client : DevExpress.XtraEditors.XtraForm
    {
        public Client(string username)
        {
            InitializeComponent();

            labelUsername.Text += username;
        }

        private void ListboxConnectedClients_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listboxConnectedClients.IndexFromPoint(e.Location);
            if (index != -1)
            {
                bool found = false;
                foreach (XtraTabPage tab in tabChat.TabPages)
                {
                    if (tab.Text == listboxConnectedClients.Items[index].ToString())
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    tabChat.TabPages.Add(listboxConnectedClients.Items[index].ToString());
                }                
            }
        }

        private void TabChat_CloseButtonClick(object sender, EventArgs e)
        {
            tabChat.TabPages.Remove((e as ClosePageButtonEventArgs).Page as XtraTabPage);
        }
    }
}