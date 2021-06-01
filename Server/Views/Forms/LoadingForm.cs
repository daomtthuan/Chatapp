using Chatapp.ChatappServer.Properties;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.Views.Forms {
  public partial class LoadingForm : SplashScreen {
    public LoadingForm() {
      InitializeComponent();
      Icon = Resources.Icon;
    }

    private void LoadingForm_Load(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      var year = DateTime.Now.Year;
      copyrighLabelControl.Text = year == 2021 ? "Copyright © Daomtthuan 2021" : ("Copyright © Daomtthuan 2021 - " + year);
    }

    public override void ProcessCommand(Enum command, object argument) {
      base.ProcessCommand(command, argument);
      switch ((SplashScreenCommand)command) {
        case SplashScreenCommand.Update:
          statusLabelControl.Text = argument.ToString();
          break;
      }
    }

    public enum SplashScreenCommand {
      Update
    }
  }
}
