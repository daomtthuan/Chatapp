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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutName = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.layoutLogin = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.Controls.Add(this.textEdit1);
            this.layoutMain.Controls.Add(this.textEdit2);
            this.layoutMain.Controls.Add(this.buttonLogin);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(382, 170);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutPassword,
            this.layoutName,
            this.layoutLogin});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(382, 170);
            this.Root.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 36);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(358, 28);
            this.textEdit1.StyleController = this.layoutMain;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutName
            // 
            this.layoutName.Control = this.textEdit1;
            this.layoutName.Location = new System.Drawing.Point(0, 0);
            this.layoutName.Name = "layoutName";
            this.layoutName.Size = new System.Drawing.Size(362, 56);
            this.layoutName.Text = "Name";
            this.layoutName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutName.TextSize = new System.Drawing.Size(59, 21);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(12, 92);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(358, 28);
            this.textEdit2.StyleController = this.layoutMain;
            this.textEdit2.TabIndex = 5;
            // 
            // layoutPassword
            // 
            this.layoutPassword.Control = this.textEdit2;
            this.layoutPassword.Location = new System.Drawing.Point(0, 56);
            this.layoutPassword.Name = "layoutPassword";
            this.layoutPassword.Size = new System.Drawing.Size(362, 56);
            this.layoutPassword.Text = "Password";
            this.layoutPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutPassword.TextSize = new System.Drawing.Size(59, 21);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 132);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(358, 26);
            this.buttonLogin.StyleController = this.layoutMain;
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            // 
            // layoutLogin
            // 
            this.layoutLogin.Control = this.buttonLogin;
            this.layoutLogin.Location = new System.Drawing.Point(0, 112);
            this.layoutLogin.Name = "layoutLogin";
            this.layoutLogin.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutLogin.Size = new System.Drawing.Size(362, 38);
            this.layoutLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layoutLogin.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 170);
            this.Controls.Add(this.layoutMain);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutName;
        private DevExpress.XtraLayout.LayoutControlItem layoutLogin;
    }
}