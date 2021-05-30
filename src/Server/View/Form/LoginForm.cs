using Chatapp.Core.Helper.View;
using Chatapp.Server.Helper;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Chatapp.Server.View.Form {
  public partial class LoginForm : XtraForm {
    public MainForm MainForm { get; private set; }

    public LoginForm(MainForm mainForm) {
      this.InitializeComponent();

      this.MainForm = mainForm;
    }

    private void LoginSimpleButton_Click(object sender, System.EventArgs e) {
      var username = this.usernameTextEdit.EditValue.ToString();
      var password = this.passwordTextEdit.EditValue.ToString();

      if (!Regex.IsMatch(username, RegexPattern.USERNAME) || !Regex.IsMatch(password, RegexPattern.PASSWORD)) {
        Alert.Warning("Invalid account");
        return;
      }

      if (this.MainForm.Server.Authenticate(username, password)) {
        this.DialogResult = DialogResult.OK;
        this.Close();
        return;
      }

      Alert.Warning("Wrong username or password");
    }
  }
}
