using Chatapp.ChatappClient.View.Form;
using System;
using System.Windows.Forms;

namespace Chatapp.ChatappClient.App {
  class Program {
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
