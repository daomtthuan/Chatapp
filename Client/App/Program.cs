using Chatapp.ChatappClient.Views.Forms;
using Chatapp.ChatappCore.ViewHelpers;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatapp.ChatappClient.App {
  class Program {
    [STAThread]
    public static async Task Main() {
      await Loading.Show<LoadingForm>();
      await Loading.UpdateMessage(LoadingForm.SplashScreenCommand.Update, "Startup...");

      await Loading.UpdateMessage(LoadingForm.SplashScreenCommand.Update, "Setup theme...");
      WindowsFormsSettings.LoadApplicationSettings();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      await Loading.UpdateMessage(LoadingForm.SplashScreenCommand.Update, "Done.");
      Application.Run(new MainForm() { Display = false });
    }
  }
}
