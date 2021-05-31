using Chatapp.bll;
using Chatapp.ui;
using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace Chatapp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            BllClient.Instance.Main = new Main();
            Application.Run(BllClient.Instance.Main);
        }
    }
}
