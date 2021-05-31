using Chatapp.ChatappServer.View.Form;
using System;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.App {
  class Program {
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
