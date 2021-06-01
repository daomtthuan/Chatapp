using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatapp.ChatappCore.ViewHelpers {
  public static class Loading {
    public static async Task Show<T>() where T : SplashScreen {
      try {
        SplashScreenManager.ShowForm(typeof(T), false, false);
        await Task.Delay(500);
      } catch (Exception) {
        Alert.Error("An error occurred when starting up");
        Application.Exit();
      }
    }

    public static async Task UpdateMessage(Enum command, string message) {
      try {
        SplashScreenManager.Default.SendCommand(command, message);
        await Task.Delay(500);
      } catch (Exception) {
        Alert.Error("An error occurred when starting up");
        Application.Exit();
      }
    }

    public static async Task Close() {
      try {
        await Task.Delay(500);
        SplashScreenManager.CloseForm();
      } catch (Exception) {
        Alert.Error("An error occurred when starting up");
        Application.Exit();
      }
    }
  }
}
