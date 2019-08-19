using DevExpress.UserSkins;
using System;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.Config.ConnectString = ConfigurationManager.ConnectionStrings["Chatapp"].ConnectionString;
            Data.Config.Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new Server());
        }
    }
}
