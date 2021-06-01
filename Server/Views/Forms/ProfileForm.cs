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
  public partial class ProfileForm : XtraForm {
    private readonly ChatappEntities _entities;

    public ProfileForm() {
      InitializeComponent();
      Icon = Resources.Icon;
      _entities = new ChatappEntities();
    }

    private void ProfileForm_Load(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      var information = _entities.Information.Find(Server.Instance.InformationId);

      fullNameTextEdit.EditValue = information.FullName;
      genderRadioGroup.EditValue = information.Gender;
      birthdayDateEdit.EditValue = information.Birthday;
      emailTextEdit.EditValue = information.Email;
      phoneTextEdit.EditValue = information.Phone;
      addressMemoEdit.EditValue = information.Address;
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

      var information = _entities.Information.Find(Server.Instance.InformationId);
      information.FullName = fullName;
      information.Gender = gender;
      information.Birthday = birthday;
      information.Email = email;
      information.Phone = phone;
      information.Address = address;
      _entities.SaveChanges();
      Cursor = Cursors.Default;
      Alert.Information("Successful change information");
      Close();
    }

    private void ChangePasswordSimpleButton_Click(object sender, EventArgs e) {
      var changePasswordForm = new ChangePasswordForm();
      Hide();
      changePasswordForm.ShowDialog();
      Show();
    }
  }
}
