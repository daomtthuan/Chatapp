
namespace Chatapp.ChatappServer.Views.Forms {
  partial class ChangePasswordForm {
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
      this.oldPasswordLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.oldPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.newPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.newPasswordLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.rePasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.rePasswordLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rePasswordTextEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // oldPasswordLabelControl
      // 
      this.oldPasswordLabelControl.Location = new System.Drawing.Point(12, 12);
      this.oldPasswordLabelControl.Name = "oldPasswordLabelControl";
      this.oldPasswordLabelControl.Size = new System.Drawing.Size(78, 16);
      this.oldPasswordLabelControl.TabIndex = 0;
      this.oldPasswordLabelControl.Text = "Old password";
      // 
      // oldPasswordTextEdit
      // 
      this.oldPasswordTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.oldPasswordTextEdit.Location = new System.Drawing.Point(12, 34);
      this.oldPasswordTextEdit.Name = "oldPasswordTextEdit";
      this.oldPasswordTextEdit.Properties.PasswordChar = '*';
      this.oldPasswordTextEdit.Size = new System.Drawing.Size(358, 22);
      this.oldPasswordTextEdit.TabIndex = 1;
      // 
      // newPasswordTextEdit
      // 
      this.newPasswordTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.newPasswordTextEdit.Location = new System.Drawing.Point(12, 84);
      this.newPasswordTextEdit.Name = "newPasswordTextEdit";
      this.newPasswordTextEdit.Properties.PasswordChar = '*';
      this.newPasswordTextEdit.Size = new System.Drawing.Size(358, 22);
      this.newPasswordTextEdit.TabIndex = 2;
      // 
      // newPasswordLabelControl
      // 
      this.newPasswordLabelControl.Location = new System.Drawing.Point(12, 62);
      this.newPasswordLabelControl.Name = "newPasswordLabelControl";
      this.newPasswordLabelControl.Size = new System.Drawing.Size(84, 16);
      this.newPasswordLabelControl.TabIndex = 0;
      this.newPasswordLabelControl.Text = "New password";
      // 
      // rePasswordTextEdit
      // 
      this.rePasswordTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rePasswordTextEdit.Location = new System.Drawing.Point(12, 134);
      this.rePasswordTextEdit.Name = "rePasswordTextEdit";
      this.rePasswordTextEdit.Properties.PasswordChar = '*';
      this.rePasswordTextEdit.Size = new System.Drawing.Size(358, 22);
      this.rePasswordTextEdit.TabIndex = 3;
      // 
      // rePasswordLabelControl
      // 
      this.rePasswordLabelControl.Location = new System.Drawing.Point(12, 112);
      this.rePasswordLabelControl.Name = "rePasswordLabelControl";
      this.rePasswordLabelControl.Size = new System.Drawing.Size(137, 16);
      this.rePasswordLabelControl.TabIndex = 0;
      this.rePasswordLabelControl.Text = "Re-enter new password";
      // 
      // saveSimpleButton
      // 
      this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.saveSimpleButton.Appearance.Options.UseBackColor = true;
      this.saveSimpleButton.Location = new System.Drawing.Point(253, 162);
      this.saveSimpleButton.Name = "saveSimpleButton";
      this.saveSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.saveSimpleButton.TabIndex = 4;
      this.saveSimpleButton.Text = "Save";
      this.saveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
      // 
      // ChangePasswordForm
      // 
      this.AcceptButton = this.saveSimpleButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 201);
      this.Controls.Add(this.saveSimpleButton);
      this.Controls.Add(this.rePasswordTextEdit);
      this.Controls.Add(this.rePasswordLabelControl);
      this.Controls.Add(this.newPasswordTextEdit);
      this.Controls.Add(this.newPasswordLabelControl);
      this.Controls.Add(this.oldPasswordTextEdit);
      this.Controls.Add(this.oldPasswordLabelControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ChangePasswordForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chatapp Server - Change password";
      ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rePasswordTextEdit.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl oldPasswordLabelControl;
    private DevExpress.XtraEditors.TextEdit oldPasswordTextEdit;
    private DevExpress.XtraEditors.TextEdit newPasswordTextEdit;
    private DevExpress.XtraEditors.LabelControl newPasswordLabelControl;
    private DevExpress.XtraEditors.TextEdit rePasswordTextEdit;
    private DevExpress.XtraEditors.LabelControl rePasswordLabelControl;
    private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
  }
}