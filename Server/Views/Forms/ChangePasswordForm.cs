using Chatapp.ChatappCore.DataHelpers;
using Chatapp.ChatappCore.ViewHelpers;
using Chatapp.ChatappServer.App;
using Chatapp.ChatappServer.Models;
using Chatapp.ChatappServer.Properties;
using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.Views.Forms {
  public partial class ChangePasswordForm : XtraForm {
    private readonly ChatappEntities _entities;

    public ChangePasswordForm() {
      InitializeComponent();
      Icon = Resources.Icon;
      _entities = new ChatappEntities();
    }

    private void SaveSimpleButton_Click(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;

      var oldPassword = oldPasswordTextEdit.Text;
      var newPassword = newPasswordTextEdit.Text;
      var rePassword = rePasswordTextEdit.Text;

      if (!Regex.IsMatch(oldPassword, RegexPattern.PASSWORD) || !Regex.IsMatch(newPassword, RegexPattern.PASSWORD)) {
        Cursor = Cursors.Default;
        Alert.Warning("Invalid password");
        return;
      }

      if (newPassword != rePassword) {
        Cursor = Cursors.Default;
        Alert.Warning("Re-entered password not match");
        return;
      }

      var account = _entities.Admins.Find(Server.Instance.Id);
      if (!BCrypt.Net.BCrypt.Verify(oldPassword, account.Password)) {
        Cursor = Cursors.Default;
        Alert.Warning("Incorrect password");
        return;
      }

      account.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
      _entities.SaveChanges();
      Cursor = Cursors.Default;
      Alert.Information("Successful change information");
      Close();
    }
  }
}
