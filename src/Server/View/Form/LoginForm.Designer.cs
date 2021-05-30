
namespace Chatapp.Server.View.Form {
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
      this.titleControl = new Chatapp.Server.View.Control.TitleControl();
      ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // usernameLabelControl
      // 
      this.usernameLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.usernameLabelControl.Appearance.Options.UseFont = true;
      this.usernameLabelControl.Location = new System.Drawing.Point(6, 62);
      this.usernameLabelControl.Name = "usernameLabelControl";
      this.usernameLabelControl.Size = new System.Drawing.Size(58, 13);
      this.usernameLabelControl.TabIndex = 0;
      this.usernameLabelControl.Text = "Username";
      // 
      // passwordLabelControl
      // 
      this.passwordLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.passwordLabelControl.Appearance.Options.UseFont = true;
      this.passwordLabelControl.Location = new System.Drawing.Point(6, 107);
      this.passwordLabelControl.Name = "passwordLabelControl";
      this.passwordLabelControl.Size = new System.Drawing.Size(54, 13);
      this.passwordLabelControl.TabIndex = 1;
      this.passwordLabelControl.Text = "Password";
      // 
      // usernameTextEdit
      // 
      this.usernameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.usernameTextEdit.Location = new System.Drawing.Point(6, 81);
      this.usernameTextEdit.Name = "usernameTextEdit";
      this.usernameTextEdit.Size = new System.Drawing.Size(227, 20);
      this.usernameTextEdit.TabIndex = 2;
      // 
      // passwordTextEdit
      // 
      this.passwordTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.passwordTextEdit.Location = new System.Drawing.Point(6, 126);
      this.passwordTextEdit.Name = "passwordTextEdit";
      this.passwordTextEdit.Properties.PasswordChar = '*';
      this.passwordTextEdit.Properties.UseSystemPasswordChar = true;
      this.passwordTextEdit.Size = new System.Drawing.Size(227, 20);
      this.passwordTextEdit.TabIndex = 3;
      // 
      // loginSimpleButton
      // 
      this.loginSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.loginSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.loginSimpleButton.Appearance.Options.UseBackColor = true;
      this.loginSimpleButton.Location = new System.Drawing.Point(133, 155);
      this.loginSimpleButton.Name = "loginSimpleButton";
      this.loginSimpleButton.Size = new System.Drawing.Size(100, 23);
      this.loginSimpleButton.TabIndex = 5;
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
      this.titleControl.Location = new System.Drawing.Point(50, 6);
      this.titleControl.Name = "titleControl";
      this.titleControl.Padding = new System.Windows.Forms.Padding(3);
      this.titleControl.Size = new System.Drawing.Size(138, 50);
      this.titleControl.TabIndex = 4;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.loginSimpleButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(239, 184);
      this.Controls.Add(this.loginSimpleButton);
      this.Controls.Add(this.titleControl);
      this.Controls.Add(this.passwordTextEdit);
      this.Controls.Add(this.usernameTextEdit);
      this.Controls.Add(this.passwordLabelControl);
      this.Controls.Add(this.usernameLabelControl);
      this.MaximizeBox = false;
      this.Name = "LoginForm";
      this.Padding = new System.Windows.Forms.Padding(3);
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
    private Control.TitleControl titleControl;
    private DevExpress.XtraEditors.SimpleButton loginSimpleButton;
  }
}