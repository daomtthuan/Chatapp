using Chatapp.ChatappCore.DataHelpers;
using Chatapp.ChatappCore.ViewHelpers;
using Chatapp.ChatappServer.Models;
using Chatapp.ChatappServer.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Chatapp.ChatappServer.Views.Forms {
  public partial class ClientsProfileForm : XtraForm {
    private readonly ChatappEntities _entities;

    public ClientsProfileForm() {
      InitializeComponent();
      Icon = Resources.Icon;
      _entities = new ChatappEntities();
      _entities.Users.Load();
      usersBindingSource.DataSource = _entities.Users.Local.ToBindingList();
    }

    private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
      if (e.FocusedRowHandle < 0) {
        saveSimpleButton.Enabled = false;
        resetPasswordSimpleButton.Enabled = false;
        return;
      }

      saveSimpleButton.Enabled = true;
      resetPasswordSimpleButton.Enabled = true;

      Cursor = Cursors.WaitCursor;
      var account = (User)usersBindingSource.Current;
      fullNameTextEdit.EditValue = account.Information.FullName;
      genderRadioGroup.EditValue = account.Information.Gender;
      birthdayDateEdit.EditValue = account.Information.Birthday;
      emailTextEdit.EditValue = account.Information.Email;
      phoneTextEdit.EditValue = account.Information.Phone;
      addressMemoEdit.EditValue = account.Information.Address;
      Cursor = Cursors.Default;
    }

    private void SaveSimpleButton_Click(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;

      var fullName = fullNameTextEdit.Text;
      var gender = (bool)genderRadioGroup.EditValue;
      var birthday = birthdayDateEdit.DateTime.Date;
      var email = emailTextEdit.Text;
      var phone = phoneTextEdit.Text;
      var address = addressMemoEdit.Text;

      if (!Regex.IsMatch(fullName, RegexPattern.FULL_NAME) || !Regex.IsMatch(email, RegexPattern.EMAIL) || !Regex.IsMatch(phone, RegexPattern.PHONE) || !Regex.IsMatch(address, RegexPattern.ADDRESS)) {
        Cursor = Cursors.Default;
        Alert.Warning("Invalid information");
        return;
      }

      var account = (User)usersBindingSource.Current;
      account.Information.FullName = fullName;
      account.Information.Gender = gender;
      account.Information.Birthday = birthday;
      account.Information.Email = email;
      account.Information.Phone = phone;
      account.Information.Address = address;
      _entities.SaveChanges();
      Cursor = Cursors.Default;
      Alert.Information("Successful change information");
    }

    private void ResetPasswordSimpleButton_Click(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      var account = (User)usersBindingSource.Current;
      account.Password = BCrypt.Net.BCrypt.HashPassword("123456");
      _entities.SaveChanges();
      Cursor = Cursors.Default;
      Alert.Information("Successful reset password. New password: 123456");
    }
  }
}
