namespace Server.Forms
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
            this.layoutMain = new DevExpress.XtraLayout.LayoutControl();
            this.textAdministrator = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.labelTitleForm = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutAdministrator = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutEmpty2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textAdministrator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitleForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEmpty2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.Controls.Add(this.textAdministrator);
            this.layoutMain.Controls.Add(this.textPassword);
            this.layoutMain.Controls.Add(this.buttonLogin);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(370, 202);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // textAdministrator
            // 
            this.textAdministrator.EditValue = "admin";
            this.textAdministrator.Location = new System.Drawing.Point(12, 73);
            this.textAdministrator.Name = "textAdministrator";
            this.textAdministrator.Size = new System.Drawing.Size(346, 28);
            this.textAdministrator.StyleController = this.layoutMain;
            this.textAdministrator.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.EditValue = "1";
            this.textPassword.Location = new System.Drawing.Point(12, 129);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(346, 28);
            this.textPassword.StyleController = this.layoutMain;
            this.textPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(186, 161);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(172, 26);
            this.buttonLogin.StyleController = this.layoutMain;
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.labelTitleForm,
            this.layoutAdministrator,
            this.layoutPassword,
            this.layoutLogin,
            this.layoutEmpty2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 202);
            this.Root.TextVisible = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AllowHotTrack = false;
            this.labelTitleForm.AppearanceItemCaption.Font = new System.Drawing.Font("Lexend Deca", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleForm.AppearanceItemCaption.Options.UseFont = true;
            this.labelTitleForm.AppearanceItemCaption.Options.UseTextOptions = true;
            this.labelTitleForm.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitleForm.Location = new System.Drawing.Point(0, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(350, 37);
            this.labelTitleForm.Text = "Chatme Server";
            this.labelTitleForm.TextSize = new System.Drawing.Size(150, 33);
            // 
            // layoutAdministrator
            // 
            this.layoutAdministrator.Control = this.textAdministrator;
            this.layoutAdministrator.Location = new System.Drawing.Point(0, 37);
            this.layoutAdministrator.Name = "layoutAdministrator";
            this.layoutAdministrator.Size = new System.Drawing.Size(350, 56);
            this.layoutAdministrator.Text = "Administrator";
            this.layoutAdministrator.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutAdministrator.TextSize = new System.Drawing.Size(150, 21);
            // 
            // layoutPassword
            // 
            this.layoutPassword.Control = this.textPassword;
            this.layoutPassword.Location = new System.Drawing.Point(0, 93);
            this.layoutPassword.Name = "layoutPassword";
            this.layoutPassword.Size = new System.Drawing.Size(350, 56);
            this.layoutPassword.Text = "Password";
            this.layoutPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutPassword.TextSize = new System.Drawing.Size(150, 21);
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
            // layoutEmpty2
            // 
            this.layoutEmpty2.AllowHotTrack = false;
            this.layoutEmpty2.Location = new System.Drawing.Point(0, 149);
            this.layoutEmpty2.Name = "layoutEmpty2";
            this.layoutEmpty2.Size = new System.Drawing.Size(174, 33);
            this.layoutEmpty2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 202);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Server.Properties.Resources.Server;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textAdministrator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitleForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEmpty2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textAdministrator;
        private DevExpress.XtraLayout.SimpleLabelItem labelTitleForm;
        private DevExpress.XtraLayout.LayoutControlItem layoutAdministrator;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutLogin;
        private DevExpress.XtraLayout.EmptySpaceItem layoutEmpty2;
    }
}