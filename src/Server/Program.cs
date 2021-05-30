using Chatapp.Server.View.Form;
using System;
using System.Windows.Forms;

namespace Chatapp.Server {
  internal static class Program {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm() { Visible = false });
    }
  }
}
