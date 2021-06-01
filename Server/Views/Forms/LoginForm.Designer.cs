
namespace Chatapp.ChatappServer.Views.Forms {
  partial class LoginForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.usernameLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.usernameTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.loginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.titleControl = new Chatapp.ChatappServer.Views.Controls.TitleControl();
      ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // usernameLabelControl
      // 
      this.usernameLabelControl.Location = new System.Drawing.Point(14, 79);
      this.usernameLabelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.usernameLabelControl.Name = "usernameLabelControl";
      this.usernameLabelControl.Size = new System.Drawing.Size(58, 16);
      this.usernameLabelControl.TabIndex = 0;
      this.usernameLabelControl.Text = "Username";
      // 
      // passwordLabelControl
      // 
      this.passwordLabelControl.Location = new System.Drawing.Point(14, 125);
      this.passwordLabelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.passwordLabelControl.Name = "passwordLabelControl";
      this.passwordLabelControl.Size = new System.Drawing.Size(55, 16);
      this.passwordLabelControl.TabIndex = 1;
      this.passwordLabelControl.Text = "Password";
      // 
      // usernameTextEdit
      // 
      this.usernameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.usernameTextEdit.Location = new System.Drawing.Point(14, 99);
      this.usernameTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.usernameTextEdit.Name = "usernameTextEdit";
      this.usernameTextEdit.Size = new System.Drawing.Size(279, 22);
      this.usernameTextEdit.TabIndex = 1;
      // 
      // passwordTextEdit
      // 
      this.passwordTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.passwordTextEdit.Location = new System.Drawing.Point(14, 145);
      this.passwordTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.passwordTextEdit.Name = "passwordTextEdit";
      this.passwordTextEdit.Properties.PasswordChar = '*';
      this.passwordTextEdit.Size = new System.Drawing.Size(279, 22);
      this.passwordTextEdit.TabIndex = 2;
      // 
      // loginSimpleButton
      // 
      this.loginSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loginSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.loginSimpleButton.Appearance.Options.UseBackColor = true;
      this.loginSimpleButton.Location = new System.Drawing.Point(176, 171);
      this.loginSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.loginSimpleButton.Name = "loginSimpleButton";
      this.loginSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.loginSimpleButton.TabIndex = 3;
      this.loginSimpleButton.Text = "Login";
      this.loginSimpleButton.Click += new System.EventHandler(this.LoginSimpleButton_Click);
      // 
      // titleControl
      // 
      this.titleControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.titleControl.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.titleControl.Appearance.Options.UseBackColor = true;
      this.titleControl.AutoSize = true;
      this.titleControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.titleControl.Location = new System.Drawing.Point(74, 14);
      this.titleControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.titleControl.Name = "titleControl";
      this.titleControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.titleControl.Size = new System.Drawing.Size(158, 61);
      this.titleControl.TabIndex = 4;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.loginSimpleButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(307, 213);
      this.Controls.Add(this.titleControl);
      this.Controls.Add(this.loginSimpleButton);
      this.Controls.Add(this.passwordTextEdit);
      this.Controls.Add(this.usernameTextEdit);
      this.Controls.Add(this.passwordLabelControl);
      this.Controls.Add(this.usernameLabelControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chatapp Server - Login";
      ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl usernameLabelControl;
    private DevExpress.XtraEditors.LabelControl passwordLabelControl;
    private DevExpress.XtraEditors.TextEdit usernameTextEdit;
    private DevExpress.XtraEditors.TextEdit passwordTextEdit;
    private DevExpress.XtraEditors.SimpleButton loginSimpleButton;
    private Controls.TitleControl titleControl;
  }
}