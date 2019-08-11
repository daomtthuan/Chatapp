namespace Client.Forms
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.labelTitle = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutEmpty2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutPassword = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEmpty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textUsername);
            this.layoutControl1.Controls.Add(this.textPassword);
            this.layoutControl1.Controls.Add(this.buttonLogin);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1009, 217, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(370, 202);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textUsername
            // 
            this.textUsername.EditValue = "User1";
            this.textUsername.Location = new System.Drawing.Point(12, 72);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(346, 28);
            this.textUsername.StyleController = this.layoutControl1;
            this.textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.EditValue = "1";
            this.textPassword.Location = new System.Drawing.Point(12, 129);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(346, 28);
            this.textPassword.StyleController = this.layoutControl1;
            this.textPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(186, 161);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(172, 27);
            this.buttonLogin.StyleController = this.layoutControl1;
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.labelTitle,
            this.layoutEmpty2,
            this.layoutLogin,
            this.layoutUsername,
            this.layoutPassword});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 202);
            this.Root.TextVisible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AllowHotTrack = false;
            this.labelTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Lexend Deca", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.AppearanceItemCaption.Options.UseFont = true;
            this.labelTitle.AppearanceItemCaption.Options.UseTextOptions = true;
            this.labelTitle.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(350, 35);
            this.labelTitle.Text = "Chatme";
            this.labelTitle.TextSize = new System.Drawing.Size(83, 35);
            // 
            // layoutEmpty2
            // 
            this.layoutEmpty2.AllowHotTrack = false;
            this.layoutEmpty2.Location = new System.Drawing.Point(0, 149);
            this.layoutEmpty2.Name = "layoutEmpty2";
            this.layoutEmpty2.Size = new System.Drawing.Size(174, 33);
            this.layoutEmpty2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutLogin
            // 
            this.layoutLogin.Control = this.buttonLogin;
            this.layoutLogin.Location = new System.Drawing.Point(174, 149);
            this.layoutLogin.Name = "layoutLogin";
            this.layoutLogin.Size = new System.Drawing.Size(176, 33);
            this.layoutLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layoutLogin.TextVisible = false;
            // 
            // layoutUsername
            // 
            this.layoutUsername.Control = this.textUsername;
            this.layoutUsername.Location = new System.Drawing.Point(0, 35);
            this.layoutUsername.Name = "layoutUsername";
            this.layoutUsername.Size = new System.Drawing.Size(350, 57);
            this.layoutUsername.Text = "Username";
            this.layoutUsername.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutUsername.TextSize = new System.Drawing.Size(83, 22);
            // 
            // layoutPassword
            // 
            this.layoutPassword.Control = this.textPassword;
            this.layoutPassword.Location = new System.Drawing.Point(0, 92);
            this.layoutPassword.Name = "layoutPassword";
            this.layoutPassword.Size = new System.Drawing.Size(350, 57);
            this.layoutPassword.Text = "Passowrd";
            this.layoutPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutPassword.TextSize = new System.Drawing.Size(83, 22);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 202);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Client.Properties.Resources.Client;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEmpty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem labelTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutUsername;
        private DevExpress.XtraLayout.LayoutControlItem layoutPassword;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraLayout.EmptySpaceItem layoutEmpty2;
        private DevExpress.XtraLayout.LayoutControlItem layoutLogin;
    }
}