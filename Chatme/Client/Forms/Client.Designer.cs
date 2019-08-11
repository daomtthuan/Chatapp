namespace Client.Forms
{
    partial class Client
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
            this.tabChat = new DevExpress.XtraTab.XtraTabControl();
            this.listboxConnectedClients = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutConnectedClients = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelOnline = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutTabChat = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelUsername = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxConnectedClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutConnectedClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTabChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.Controls.Add(this.tabChat);
            this.layoutMain.Controls.Add(this.listboxConnectedClients);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(1292, 755);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // tabChat
            // 
            this.tabChat.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.tabChat.Location = new System.Drawing.Point(284, 14);
            this.tabChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(994, 727);
            this.tabChat.TabIndex = 5;
            this.tabChat.CloseButtonClick += new System.EventHandler(this.TabChat_CloseButtonClick);
            // 
            // listboxConnectedClients
            // 
            this.listboxConnectedClients.Location = new System.Drawing.Point(14, 77);
            this.listboxConnectedClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listboxConnectedClients.Name = "listboxConnectedClients";
            this.listboxConnectedClients.Size = new System.Drawing.Size(266, 664);
            this.listboxConnectedClients.StyleController = this.layoutMain;
            this.listboxConnectedClients.TabIndex = 4;
            this.listboxConnectedClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListboxConnectedClients_MouseClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutConnectedClients,
            this.labelOnline,
            this.layoutTabChat,
            this.labelUsername});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1292, 755);
            this.Root.TextVisible = false;
            // 
            // layoutConnectedClients
            // 
            this.layoutConnectedClients.Control = this.listboxConnectedClients;
            this.layoutConnectedClients.Location = new System.Drawing.Point(0, 63);
            this.layoutConnectedClients.MaxSize = new System.Drawing.Size(270, 0);
            this.layoutConnectedClients.MinSize = new System.Drawing.Size(270, 5);
            this.layoutConnectedClients.Name = "layoutConnectedClients";
            this.layoutConnectedClients.Size = new System.Drawing.Size(270, 668);
            this.layoutConnectedClients.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutConnectedClients.TextSize = new System.Drawing.Size(0, 0);
            this.layoutConnectedClients.TextVisible = false;
            // 
            // labelOnline
            // 
            this.labelOnline.AllowHotTrack = false;
            this.labelOnline.Location = new System.Drawing.Point(0, 31);
            this.labelOnline.MaxSize = new System.Drawing.Size(270, 32);
            this.labelOnline.MinSize = new System.Drawing.Size(270, 32);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(270, 32);
            this.labelOnline.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.labelOnline.Text = "Online";
            this.labelOnline.TextSize = new System.Drawing.Size(52, 27);
            // 
            // layoutTabChat
            // 
            this.layoutTabChat.Control = this.tabChat;
            this.layoutTabChat.Location = new System.Drawing.Point(270, 0);
            this.layoutTabChat.Name = "layoutTabChat";
            this.layoutTabChat.Size = new System.Drawing.Size(998, 731);
            this.layoutTabChat.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTabChat.TextVisible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AllowHotTrack = false;
            this.labelUsername.Location = new System.Drawing.Point(0, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(270, 31);
            this.labelUsername.Text = "User: ";
            this.labelUsername.TextSize = new System.Drawing.Size(52, 27);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 755);
            this.Controls.Add(this.layoutMain);
            this.Icon = global::Client.Properties.Resources.Client;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxConnectedClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutConnectedClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTabChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl listboxConnectedClients;
        private DevExpress.XtraLayout.SimpleLabelItem labelOnline;
        private DevExpress.XtraLayout.LayoutControlItem layoutConnectedClients;
        private DevExpress.XtraTab.XtraTabControl tabChat;
        private DevExpress.XtraLayout.LayoutControlItem layoutTabChat;
        private DevExpress.XtraLayout.SimpleLabelItem labelUsername;
    }
}