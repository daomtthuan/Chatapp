using Chatapp.ChatappCore.DataHelpers;
using Chatapp.ChatappCore.ViewHelpers;
using Chatapp.ChatappServer.App;
using Chatapp.ChatappServer.Properties;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.Views.Forms {
  public partial class LoginForm : XtraForm {
    public LoginForm() {
      InitializeComponent();
      Icon = Resources.Icon;
    }

    private void LoginSimpleButton_Click(object sender, System.EventArgs e) {
      Cursor = Cursors.WaitCursor;

      var username = usernameTextEdit.EditValue.ToString();
      var password = passwordTextEdit.EditValue.ToString();

      if (!Regex.IsMatch(username, RegexPattern.USERNAME) || !Regex.IsMatch(password, RegexPattern.PASSWORD)) {
        Alert.Warning("Invalid account");
        return;
      }

      if (Server.Instance.Login(username, password)) {
        DialogResult = DialogResult.OK;
        Close();
        return;
      }

      Cursor = Cursors.Default;
      Alert.Warning("Incorrect username or password");
    }
  }
}
