namespace Server
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
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AllowCustomization = false;
            this.layoutMain.Controls.Add(this.textName);
            this.layoutMain.Controls.Add(this.textPassword);
            this.layoutMain.Controls.Add(this.buttonLogin);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(337, 150);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(11, 30);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(315, 24);
            this.textName.StyleController = this.layoutMain;
            this.textName.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(11, 78);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(315, 24);
            this.textPassword.StyleController = this.layoutMain;
            this.textPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonLogin.Appearance.Options.UseBackColor = true;
            this.buttonLogin.Location = new System.Drawing.Point(170, 118);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(156, 22);
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
            this.layoutPassword,
            this.layoutName,
            this.layoutLogin,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(337, 150);
            this.Root.TextVisible = false;
            // 
            // layoutPassword
            // 
            this.layoutPassword.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutPassword.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutPassword.Control = this.textPassword;
            this.layoutPassword.Location = new System.Drawing.Point(0, 48);
            this.layoutPassword.Name = "layoutPassword";
            this.layoutPassword.Size = new System.Drawing.Size(319, 48);
            this.layoutPassword.Text = "Password";
            this.layoutPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutPassword.TextSize = new System.Drawing.Size(56, 17);
            // 
            // layoutName
            // 
            this.layoutName.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutName.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutName.Control = this.textName;
            this.layoutName.Location = new System.Drawing.Point(0, 0);
            this.layoutName.Name = "layoutName";
            this.layoutName.Size = new System.Drawing.Size(319, 48);
            this.layoutName.Text = "Name";
            this.layoutName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutName.TextSize = new System.Drawing.Size(56, 17);
            // 
            // layoutLogin
            // 
            this.layoutLogin.Control = this.buttonLogin;
            this.layoutLogin.Location = new System.Drawing.Point(159, 108);
            this.layoutLogin.Name = "layoutLogin";
            this.layoutLogin.Size = new System.Drawing.Size(160, 26);
            this.layoutLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layoutLogin.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(159, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(319, 12);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 150);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutName;
        private DevExpress.XtraLayout.LayoutControlItem layoutLogin;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}