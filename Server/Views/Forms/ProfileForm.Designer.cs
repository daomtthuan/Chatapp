
namespace Chatapp.ChatappServer.Views.Forms {
  partial class ProfileForm {
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
      this.fullNameLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.genderRadioGroup = new DevExpress.XtraEditors.RadioGroup();
      this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
      this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
      this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.changePasswordSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderRadioGroup.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // fullNameLabelControl
      // 
      this.fullNameLabelControl.Location = new System.Drawing.Point(12, 15);
      this.fullNameLabelControl.Name = "fullNameLabelControl";
      this.fullNameLabelControl.Size = new System.Drawing.Size(56, 16);
      this.fullNameLabelControl.TabIndex = 0;
      this.fullNameLabelControl.Text = "Full name";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(12, 65);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(41, 16);
      this.labelControl2.TabIndex = 0;
      this.labelControl2.Text = "Gender";
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(12, 115);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(46, 16);
      this.labelControl3.TabIndex = 0;
      this.labelControl3.Text = "Birthday";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(12, 165);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(31, 16);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "Email";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(12, 215);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(35, 16);
      this.labelControl5.TabIndex = 0;
      this.labelControl5.Text = "Phone";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(12, 265);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(46, 16);
      this.labelControl6.TabIndex = 0;
      this.labelControl6.Text = "Address";
      // 
      // fullNameTextEdit
      // 
      this.fullNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fullNameTextEdit.Location = new System.Drawing.Point(12, 37);
      this.fullNameTextEdit.Name = "fullNameTextEdit";
      this.fullNameTextEdit.Size = new System.Drawing.Size(364, 22);
      this.fullNameTextEdit.TabIndex = 1;
      // 
      // genderRadioGroup
      // 
      this.genderRadioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.genderRadioGroup.Location = new System.Drawing.Point(12, 87);
      this.genderRadioGroup.Name = "genderRadioGroup";
      this.genderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.genderRadioGroup.Properties.Appearance.Options.UseBackColor = true;
      this.genderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.genderRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Male", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Female", true, null, "")});
      this.genderRadioGroup.Properties.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.genderRadioGroup.Size = new System.Drawing.Size(364, 22);
      this.genderRadioGroup.TabIndex = 2;
      // 
      // birthdayDateEdit
      // 
      this.birthdayDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.birthdayDateEdit.EditValue = null;
      this.birthdayDateEdit.Location = new System.Drawing.Point(12, 137);
      this.birthdayDateEdit.Name = "birthdayDateEdit";
      this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.birthdayDateEdit.Size = new System.Drawing.Size(364, 22);
      this.birthdayDateEdit.TabIndex = 3;
      // 
      // emailTextEdit
      // 
      this.emailTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.emailTextEdit.Location = new System.Drawing.Point(12, 187);
      this.emailTextEdit.Name = "emailTextEdit";
      this.emailTextEdit.Size = new System.Drawing.Size(364, 22);
      this.emailTextEdit.TabIndex = 4;
      // 
      // phoneTextEdit
      // 
      this.phoneTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.phoneTextEdit.Location = new System.Drawing.Point(12, 237);
      this.phoneTextEdit.Name = "phoneTextEdit";
      this.phoneTextEdit.Size = new System.Drawing.Size(364, 22);
      this.phoneTextEdit.TabIndex = 5;
      // 
      // addressMemoEdit
      // 
      this.addressMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.addressMemoEdit.Location = new System.Drawing.Point(12, 287);
      this.addressMemoEdit.Name = "addressMemoEdit";
      this.addressMemoEdit.Size = new System.Drawing.Size(364, 85);
      this.addressMemoEdit.TabIndex = 6;
      // 
      // saveSimpleButton
      // 
      this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.saveSimpleButton.Appearance.Options.UseBackColor = true;
      this.saveSimpleButton.Location = new System.Drawing.Point(259, 378);
      this.saveSimpleButton.Name = "saveSimpleButton";
      this.saveSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.saveSimpleButton.TabIndex = 7;
      this.saveSimpleButton.Text = "Save";
      this.saveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
      // 
      // changePasswordSimpleButton
      // 
      this.changePasswordSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.changePasswordSimpleButton.Location = new System.Drawing.Point(12, 378);
      this.changePasswordSimpleButton.Name = "changePasswordSimpleButton";
      this.changePasswordSimpleButton.Size = new System.Drawing.Size(240, 28);
      this.changePasswordSimpleButton.TabIndex = 8;
      this.changePasswordSimpleButton.Text = "Change password";
      this.changePasswordSimpleButton.Click += new System.EventHandler(this.ChangePasswordSimpleButton_Click);
      // 
      // ProfileForm
      // 
      this.AcceptButton = this.saveSimpleButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(388, 418);
      this.Controls.Add(this.changePasswordSimpleButton);
      this.Controls.Add(this.saveSimpleButton);
      this.Controls.Add(this.addressMemoEdit);
      this.Controls.Add(this.phoneTextEdit);
      this.Controls.Add(this.emailTextEdit);
      this.Controls.Add(this.birthdayDateEdit);
      this.Controls.Add(this.genderRadioGroup);
      this.Controls.Add(this.fullNameTextEdit);
      this.Controls.Add(this.labelControl6);
      this.Controls.Add(this.labelControl5);
      this.Controls.Add(this.labelControl4);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.fullNameLabelControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ProfileForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Chatapp Server - Profile";
      this.Load += new System.EventHandler(this.ProfileForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderRadioGroup.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl fullNameLabelControl;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
    private DevExpress.XtraEditors.RadioGroup genderRadioGroup;
    private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
    private DevExpress.XtraEditors.TextEdit emailTextEdit;
    private DevExpress.XtraEditors.TextEdit phoneTextEdit;
    private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
    private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    private DevExpress.XtraEditors.SimpleButton changePasswordSimpleButton;
  }
}