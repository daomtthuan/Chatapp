using Chatapp.ChatappClient.Properties;
using Chatapp.ChatappCore.ViewHelpers;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Chatapp.ChatappClient.Views.Forms {
  public partial class MainForm : XtraForm {
    public MainForm() {
      InitializeComponent();
      Icon = Resources.Icon;
    }

    public bool Display {
      set {
        ShowInTaskbar = value;
        Visible = value;
        Opacity = value ? 1 : 0;
        FormBorderEffect = value ? FormBorderEffect.Default : FormBorderEffect.None;
        if (value) {
          Show();
        } else {
          Hide();
        }
      }
    }

    private async void MainForm_Load(object sender, System.EventArgs e) {
      Cursor = Cursors.WaitCursor;
      var loginForm = new LoginForm();
      await Loading.Close();

      if (loginForm.ShowDialog() == DialogResult.OK) {
        Display = true;
      } else {
        Application.Exit();
      }
      Cursor = Cursors.Default;
    }
  }
}
