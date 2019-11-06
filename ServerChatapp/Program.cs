using DevExpress.UserSkins;
using ServerChatapp.bll;
using ServerChatapp.ui;
using System;
using System.Windows.Forms;

namespace ServerChatapp
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
            BllServer.Instance.Main = new Main();
            Application.Run(BllServer.Instance.Main);
        }
    }
}
