namespace Chatapp.ui
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.loginSmpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.titleLabelControl.Appearance.Options.UseFont = true;
            this.titleLabelControl.Appearance.Options.UseForeColor = true;
            this.titleLabelControl.Location = new System.Drawing.Point(133, 13);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(88, 25);
            this.titleLabelControl.TabIndex = 8;
            this.titleLabelControl.Text = "Chatapp";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(12, 75);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(331, 28);
            this.nameTextEdit.TabIndex = 9;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(12, 138);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(331, 28);
            this.passwordTextEdit.TabIndex = 10;
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Location = new System.Drawing.Point(12, 48);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(42, 21);
            this.nameLabelControl.TabIndex = 11;
            this.nameLabelControl.Text = "Name";
            // 
            // passwordLabelControl
            // 
            this.passwordLabelControl.Location = new System.Drawing.Point(12, 111);
            this.passwordLabelControl.Name = "passwordLabelControl";
            this.passwordLabelControl.Size = new System.Drawing.Size(67, 21);
            this.passwordLabelControl.TabIndex = 11;
            this.passwordLabelControl.Text = "Password";
            // 
            // loginSmpleButton
            // 
            this.loginSmpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.loginSmpleButton.Appearance.Options.UseBackColor = true;
            this.loginSmpleButton.Location = new System.Drawing.Point(110, 180);
            this.loginSmpleButton.Name = "loginSmpleButton";
            this.loginSmpleButton.Size = new System.Drawing.Size(135, 35);
            this.loginSmpleButton.TabIndex = 12;
            this.loginSmpleButton.Text = "Login";
            this.loginSmpleButton.Click += new System.EventHandler(this.LoginSimpleButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginSmpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 227);
            this.Controls.Add(this.loginSmpleButton);
            this.Controls.Add(this.passwordLabelControl);
            this.Controls.Add(this.nameLabelControl);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.titleLabelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.LabelControl passwordLabelControl;
        private DevExpress.XtraEditors.SimpleButton loginSmpleButton;
    }
}