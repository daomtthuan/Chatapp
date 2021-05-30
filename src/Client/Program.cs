using Chatapp.Client.View.Form;
using System;
using System.Windows.Forms;

namespace Chatapp.Client {
  static class Program {
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
