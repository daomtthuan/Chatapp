namespace Client
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
            this.boxOnline = new DevExpress.XtraEditors.ListBoxControl();
            this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
            this.textMessage = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutOnline = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutTabChat = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutButtonSend = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTabChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutButtonSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AllowCustomization = false;
            this.layoutMain.Controls.Add(this.tabChat);
            this.layoutMain.Controls.Add(this.boxOnline);
            this.layoutMain.Controls.Add(this.buttonSend);
            this.layoutMain.Controls.Add(this.textMessage);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(924, 578);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // tabChat
            // 
            this.tabChat.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.tabChat.Location = new System.Drawing.Point(239, 36);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(673, 427);
            this.tabChat.TabIndex = 5;
            this.tabChat.CloseButtonClick += new System.EventHandler(this.TabChat_CloseButtonClick);
            // 
            // boxOnline
            // 
            this.boxOnline.Location = new System.Drawing.Point(12, 36);
            this.boxOnline.Name = "boxOnline";
            this.boxOnline.Size = new System.Drawing.Size(213, 530);
            this.boxOnline.StyleController = this.layoutMain;
            this.boxOnline.TabIndex = 4;
            this.boxOnline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxOnline_MouseClick);
            // 
            // buttonSend
            // 
            this.buttonSend.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonSend.Appearance.Options.UseBackColor = true;
            this.buttonSend.Appearance.Options.UseForeColor = true;
            this.buttonSend.Location = new System.Drawing.Point(812, 501);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 65);
            this.buttonSend.StyleController = this.layoutMain;
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(239, 501);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(569, 65);
            this.textMessage.StyleController = this.layoutMain;
            this.textMessage.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutOnline,
            this.splitterItem1,
            this.layoutTabChat,
            this.layoutMessage,
            this.layoutButtonSend,
            this.splitterItem2});
            this.Root.Name = "Root";
            this.Root.ShowInCustomizationForm = false;
            this.Root.Size = new System.Drawing.Size(924, 578);
            this.Root.TextVisible = false;
            // 
            // layoutOnline
            // 
            this.layoutOnline.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutOnline.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutOnline.Control = this.boxOnline;
            this.layoutOnline.Location = new System.Drawing.Point(0, 0);
            this.layoutOnline.Name = "layoutOnline";
            this.layoutOnline.Size = new System.Drawing.Size(217, 558);
            this.layoutOnline.Text = "Online";
            this.layoutOnline.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutOnline.TextSize = new System.Drawing.Size(55, 21);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(217, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 558);
            // 
            // layoutTabChat
            // 
            this.layoutTabChat.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutTabChat.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutTabChat.Control = this.tabChat;
            this.layoutTabChat.Location = new System.Drawing.Point(227, 0);
            this.layoutTabChat.Name = "layoutTabChat";
            this.layoutTabChat.Size = new System.Drawing.Size(677, 455);
            this.layoutTabChat.Text = " ";
            this.layoutTabChat.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTabChat.TextSize = new System.Drawing.Size(55, 21);
            // 
            // layoutMessage
            // 
            this.layoutMessage.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutMessage.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutMessage.Control = this.textMessage;
            this.layoutMessage.Location = new System.Drawing.Point(227, 465);
            this.layoutMessage.Name = "layoutMessage";
            this.layoutMessage.OptionsPrint.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutMessage.OptionsPrint.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutMessage.Size = new System.Drawing.Size(573, 93);
            this.layoutMessage.Text = "Message";
            this.layoutMessage.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutMessage.TextSize = new System.Drawing.Size(55, 21);
            // 
            // layoutButtonSend
            // 
            this.layoutButtonSend.Control = this.buttonSend;
            this.layoutButtonSend.Location = new System.Drawing.Point(800, 465);
            this.layoutButtonSend.MaxSize = new System.Drawing.Size(104, 0);
            this.layoutButtonSend.MinSize = new System.Drawing.Size(104, 30);
            this.layoutButtonSend.Name = "layoutButtonSend";
            this.layoutButtonSend.Size = new System.Drawing.Size(104, 93);
            this.layoutButtonSend.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutButtonSend.Text = " ";
            this.layoutButtonSend.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutButtonSend.TextSize = new System.Drawing.Size(55, 21);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(227, 455);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(677, 10);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(771, 0);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 578);
            this.Controls.Add(this.layoutMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatapp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Shown += new System.EventHandler(this.Client_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTabChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutButtonSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl boxOnline;
        private DevExpress.XtraLayout.LayoutControlItem layoutOnline;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl tabChat;
        private DevExpress.XtraEditors.SimpleButton buttonSend;
        private DevExpress.XtraEditors.MemoEdit textMessage;
        private DevExpress.XtraLayout.LayoutControlItem layoutTabChat;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutMessage;
        private DevExpress.XtraLayout.LayoutControlItem layoutButtonSend;
    }
}

