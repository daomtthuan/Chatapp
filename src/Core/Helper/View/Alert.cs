using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Chatapp.Core.Helper.View {
  public static class Alert {
    public static void Error(string message) {
      XtraMessageBox.Show(message, "Chatapp - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void Warning(string message) {
      XtraMessageBox.Show(message, "Chatapp - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }
}
