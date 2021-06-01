
namespace Chatapp.ChatappServer.Views.Forms {
  partial class ClientsProfileForm {
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
      this.components = new System.ComponentModel.Container();
      this.gridControl = new DevExpress.XtraGrid.GridControl();
      this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
      this.clientsListLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
      this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
      this.genderRadioGroup = new DevExpress.XtraEditors.RadioGroup();
      this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.addressLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.phoneLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.emailLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.birthdayLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.genderLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.fullNameLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.resetPasswordSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderRadioGroup.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl
      // 
      this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.gridControl.DataSource = this.usersBindingSource;
      this.gridControl.Location = new System.Drawing.Point(12, 34);
      this.gridControl.MainView = this.gridView;
      this.gridControl.Name = "gridControl";
      this.gridControl.Size = new System.Drawing.Size(315, 656);
      this.gridControl.TabIndex = 0;
      this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
      // 
      // usersBindingSource
      // 
      this.usersBindingSource.DataSource = typeof(Chatapp.ChatappServer.Models.User);
      // 
      // gridView
      // 
      this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUsername});
      this.gridView.GridControl = this.gridControl;
      this.gridView.Name = "gridView";
      this.gridView.OptionsBehavior.ReadOnly = true;
      this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView_FocusedRowChanged);
      // 
      // colId
      // 
      this.colId.FieldName = "Id";
      this.colId.Name = "colId";
      this.colId.Visible = true;
      this.colId.VisibleIndex = 0;
      this.colId.Width = 68;
      // 
      // colUsername
      // 
      this.colUsername.FieldName = "Username";
      this.colUsername.Name = "colUsername";
      this.colUsername.Visible = true;
      this.colUsername.VisibleIndex = 1;
      this.colUsername.Width = 222;
      // 
      // clientsListLabelControl
      // 
      this.clientsListLabelControl.Location = new System.Drawing.Point(12, 12);
      this.clientsListLabelControl.Name = "clientsListLabelControl";
      this.clientsListLabelControl.Size = new System.Drawing.Size(58, 16);
      this.clientsListLabelControl.TabIndex = 1;
      this.clientsListLabelControl.Text = "Clients list";
      // 
      // saveSimpleButton
      // 
      this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.saveSimpleButton.Appearance.Options.UseBackColor = true;
      this.saveSimpleButton.Enabled = false;
      this.saveSimpleButton.Location = new System.Drawing.Point(578, 662);
      this.saveSimpleButton.Name = "saveSimpleButton";
      this.saveSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.saveSimpleButton.TabIndex = 20;
      this.saveSimpleButton.Text = "Save";
      this.saveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
      // 
      // addressMemoEdit
      // 
      this.addressMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.addressMemoEdit.Location = new System.Drawing.Point(333, 306);
      this.addressMemoEdit.Name = "addressMemoEdit";
      this.addressMemoEdit.Size = new System.Drawing.Size(362, 350);
      this.addressMemoEdit.TabIndex = 19;
      // 
      // phoneTextEdit
      // 
      this.phoneTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.phoneTextEdit.Location = new System.Drawing.Point(333, 256);
      this.phoneTextEdit.Name = "phoneTextEdit";
      this.phoneTextEdit.Size = new System.Drawing.Size(362, 22);
      this.phoneTextEdit.TabIndex = 18;
      // 
      // emailTextEdit
      // 
      this.emailTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.emailTextEdit.Location = new System.Drawing.Point(333, 206);
      this.emailTextEdit.Name = "emailTextEdit";
      this.emailTextEdit.Size = new System.Drawing.Size(362, 22);
      this.emailTextEdit.TabIndex = 17;
      // 
      // birthdayDateEdit
      // 
      this.birthdayDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.birthdayDateEdit.EditValue = null;
      this.birthdayDateEdit.Location = new System.Drawing.Point(333, 156);
      this.birthdayDateEdit.Name = "birthdayDateEdit";
      this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.birthdayDateEdit.Size = new System.Drawing.Size(362, 22);
      this.birthdayDateEdit.TabIndex = 16;
      // 
      // genderRadioGroup
      // 
      this.genderRadioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.genderRadioGroup.Location = new System.Drawing.Point(333, 106);
      this.genderRadioGroup.Name = "genderRadioGroup";
      this.genderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.genderRadioGroup.Properties.Appearance.Options.UseBackColor = true;
      this.genderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.genderRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Male", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Female", true, null, "")});
      this.genderRadioGroup.Properties.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.genderRadioGroup.Size = new System.Drawing.Size(362, 22);
      this.genderRadioGroup.TabIndex = 15;
      // 
      // fullNameTextEdit
      // 
      this.fullNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.fullNameTextEdit.Location = new System.Drawing.Point(333, 56);
      this.fullNameTextEdit.Name = "fullNameTextEdit";
      this.fullNameTextEdit.Size = new System.Drawing.Size(362, 22);
      this.fullNameTextEdit.TabIndex = 14;
      // 
      // addressLabelControl
      // 
      this.addressLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.addressLabelControl.Location = new System.Drawing.Point(333, 284);
      this.addressLabelControl.Name = "addressLabelControl";
      this.addressLabelControl.Size = new System.Drawing.Size(46, 16);
      this.addressLabelControl.TabIndex = 8;
      this.addressLabelControl.Text = "Address";
      // 
      // phoneLabelControl
      // 
      this.phoneLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.phoneLabelControl.Location = new System.Drawing.Point(333, 234);
      this.phoneLabelControl.Name = "phoneLabelControl";
      this.phoneLabelControl.Size = new System.Drawing.Size(35, 16);
      this.phoneLabelControl.TabIndex = 9;
      this.phoneLabelControl.Text = "Phone";
      // 
      // emailLabelControl
      // 
      this.emailLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.emailLabelControl.Location = new System.Drawing.Point(333, 184);
      this.emailLabelControl.Name = "emailLabelControl";
      this.emailLabelControl.Size = new System.Drawing.Size(31, 16);
      this.emailLabelControl.TabIndex = 10;
      this.emailLabelControl.Text = "Email";
      // 
      // birthdayLabelControl
      // 
      this.birthdayLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.birthdayLabelControl.Location = new System.Drawing.Point(333, 134);
      this.birthdayLabelControl.Name = "birthdayLabelControl";
      this.birthdayLabelControl.Size = new System.Drawing.Size(46, 16);
      this.birthdayLabelControl.TabIndex = 11;
      this.birthdayLabelControl.Text = "Birthday";
      // 
      // genderLabelControl
      // 
      this.genderLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.genderLabelControl.Location = new System.Drawing.Point(333, 84);
      this.genderLabelControl.Name = "genderLabelControl";
      this.genderLabelControl.Size = new System.Drawing.Size(41, 16);
      this.genderLabelControl.TabIndex = 12;
      this.genderLabelControl.Text = "Gender";
      // 
      // fullNameLabelControl
      // 
      this.fullNameLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.fullNameLabelControl.Location = new System.Drawing.Point(333, 34);
      this.fullNameLabelControl.Name = "fullNameLabelControl";
      this.fullNameLabelControl.Size = new System.Drawing.Size(56, 16);
      this.fullNameLabelControl.TabIndex = 13;
      this.fullNameLabelControl.Text = "Full name";
      // 
      // resetPasswordSimpleButton
      // 
      this.resetPasswordSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.resetPasswordSimpleButton.Enabled = false;
      this.resetPasswordSimpleButton.Location = new System.Drawing.Point(333, 662);
      this.resetPasswordSimpleButton.Name = "resetPasswordSimpleButton";
      this.resetPasswordSimpleButton.Size = new System.Drawing.Size(239, 28);
      this.resetPasswordSimpleButton.TabIndex = 21;
      this.resetPasswordSimpleButton.Text = "Reset password";
      this.resetPasswordSimpleButton.Click += new System.EventHandler(this.ResetPasswordSimpleButton_Click);
      // 
      // ClientsProfileForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(707, 702);
      this.Controls.Add(this.resetPasswordSimpleButton);
      this.Controls.Add(this.saveSimpleButton);
      this.Controls.Add(this.addressMemoEdit);
      this.Controls.Add(this.phoneTextEdit);
      this.Controls.Add(this.emailTextEdit);
      this.Controls.Add(this.birthdayDateEdit);
      this.Controls.Add(this.genderRadioGroup);
      this.Controls.Add(this.fullNameTextEdit);
      this.Controls.Add(this.addressLabelControl);
      this.Controls.Add(this.phoneLabelControl);
      this.Controls.Add(this.emailLabelControl);
      this.Controls.Add(this.birthdayLabelControl);
      this.Controls.Add(this.genderLabelControl);
      this.Controls.Add(this.fullNameLabelControl);
      this.Controls.Add(this.clientsListLabelControl);
      this.Controls.Add(this.gridControl);
      this.Name = "ClientsProfileForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chatapp Server - Clients profile";
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderRadioGroup.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    private DevExpress.XtraEditors.LabelControl clientsListLabelControl;
    private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
    private DevExpress.XtraEditors.TextEdit phoneTextEdit;
    private DevExpress.XtraEditors.TextEdit emailTextEdit;
    private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
    private DevExpress.XtraEditors.RadioGroup genderRadioGroup;
    private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
    private DevExpress.XtraEditors.LabelControl addressLabelControl;
    private DevExpress.XtraEditors.LabelControl phoneLabelControl;
    private DevExpress.XtraEditors.LabelControl emailLabelControl;
    private DevExpress.XtraEditors.LabelControl birthdayLabelControl;
    private DevExpress.XtraEditors.LabelControl genderLabelControl;
    private DevExpress.XtraEditors.LabelControl fullNameLabelControl;
    private DevExpress.XtraEditors.SimpleButton resetPasswordSimpleButton;
    private System.Windows.Forms.BindingSource usersBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colId;
    private DevExpress.XtraGrid.Columns.GridColumn colUsername;
  }
}
