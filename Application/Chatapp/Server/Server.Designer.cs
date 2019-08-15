namespace Server
{
    partial class Server
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
            this.cmd = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutCommandLine = new DevExpress.XtraLayout.LayoutControlItem();
            this.listboxClients = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutClients = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCommandLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AllowCustomization = false;
            this.layoutMain.Controls.Add(this.listboxClients);
            this.layoutMain.Controls.Add(this.cmd);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(812, 409);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutCommandLine,
            this.layoutClients});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(812, 409);
            this.Root.TextVisible = false;
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(203, 36);
            this.cmd.Name = "cmd";
            this.cmd.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.cmd.Size = new System.Drawing.Size(597, 361);
            this.cmd.StyleController = this.layoutMain;
            this.cmd.TabIndex = 4;
            // 
            // layoutCommandLine
            // 
            this.layoutCommandLine.Control = this.cmd;
            this.layoutCommandLine.Location = new System.Drawing.Point(191, 0);
            this.layoutCommandLine.Name = "layoutCommandLine";
            this.layoutCommandLine.Size = new System.Drawing.Size(601, 389);
            this.layoutCommandLine.Text = "Command Line";
            this.layoutCommandLine.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutCommandLine.TextSize = new System.Drawing.Size(97, 21);
            // 
            // listboxClients
            // 
            this.listboxClients.Location = new System.Drawing.Point(12, 36);
            this.listboxClients.Name = "listboxClients";
            this.listboxClients.Size = new System.Drawing.Size(187, 361);
            this.listboxClients.StyleController = this.layoutMain;
            this.listboxClients.TabIndex = 5;
            // 
            // layoutClients
            // 
            this.layoutClients.Control = this.listboxClients;
            this.layoutClients.Location = new System.Drawing.Point(0, 0);
            this.layoutClients.MaxSize = new System.Drawing.Size(191, 0);
            this.layoutClients.MinSize = new System.Drawing.Size(191, 28);
            this.layoutClients.Name = "layoutClients";
            this.layoutClients.Size = new System.Drawing.Size(191, 389);
            this.layoutClients.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutClients.Text = "Clients";
            this.layoutClients.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutClients.TextSize = new System.Drawing.Size(97, 21);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 409);
            this.Controls.Add(this.layoutMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatapp Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Shown += new System.EventHandler(this.Server_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCommandLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl listboxClients;
        private DevExpress.XtraEditors.ListBoxControl cmd;
        private DevExpress.XtraLayout.LayoutControlItem layoutCommandLine;
        private DevExpress.XtraLayout.LayoutControlItem layoutClients;
    }
}

