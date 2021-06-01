using Chatapp.ChatappCore.ViewHelpers;
using Chatapp.ChatappServer.App;
using Chatapp.ChatappServer.Properties;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.Views.Forms {
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

    private void StartSimpleButton_Click(object sender, System.EventArgs e) {
      Cursor = Cursors.WaitCursor;
      Server.Instance.Start();
      startSimpleButton.Enabled = false;
      stopSimpleButton.Enabled = true;
      Cursor = Cursors.Default;
    }

    private void ClientsListBoxControl_SelectedIndexChanged(object sender, System.EventArgs e) {
      disconnectSimpleButton.Enabled = clientsListBoxControl.SelectedIndex >= 0;
    }

    private void ProfileSimpleButton_Click(object sender, System.EventArgs e) {
      var profileForm = new ProfileForm();
      Hide();
      profileForm.ShowDialog();
      Show();
    }

    private void ClientsSimpleButton_Click(object sender, System.EventArgs e) {
      var clientsProfileForm = new ClientsProfileForm();
      Hide();
      clientsProfileForm.ShowDialog();
      Show();
    }

    private void LogoutSimpleButton_Click(object sender, System.EventArgs e) {
      Cursor = Cursors.WaitCursor;
      Server.Instance.Logout();
      Hide();
      var loginForm = new LoginForm();
      if (loginForm.ShowDialog() == DialogResult.OK) {
        Show();
      } else {
        Application.Exit();
      }
      Cursor = Cursors.Default;
    }
  }
}
