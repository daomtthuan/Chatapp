using DevExpress.UserSkins;
using System;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

namespace Client
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
            Data.Config.IP = (ConfigurationManager.AppSettings.Get("IP").Length == 0) ?
                Dns.GetHostAddresses(Dns.GetHostName())[1] :
                IPAddress.Parse(ConfigurationManager.AppSettings.Get("IP"));
            Data.Config.Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("Port"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new Client());
        }
    }
}
