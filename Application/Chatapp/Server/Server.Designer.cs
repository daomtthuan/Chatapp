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
            Icon = Properties.Resources.ServerIcon;
            this.layoutMain = new DevExpress.XtraLayout.LayoutControl();
            this.boxClients = new DevExpress.XtraEditors.ListBoxControl();
            this.boxCmd = new DevExpress.XtraEditors.ListBoxControl();
            this.buttonDisconnect = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDisconnectAll = new DevExpress.XtraEditors.SimpleButton();
            this.boxMess = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutClients = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDisconnect = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDisconnectAll = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutCmd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMess = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AllowCustomization = false;
            this.layoutMain.Controls.Add(this.boxClients);
            this.layoutMain.Controls.Add(this.boxCmd);
            this.layoutMain.Controls.Add(this.buttonDisconnect);
            this.layoutMain.Controls.Add(this.buttonDisconnectAll);
            this.layoutMain.Controls.Add(this.boxMess);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1053, 350, 650, 400);
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(752, 612);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // boxClients
            // 
            this.boxClients.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.boxClients.Location = new System.Drawing.Point(12, 36);
            this.boxClients.Name = "boxClients";
            this.boxClients.Size = new System.Drawing.Size(178, 534);
            this.boxClients.StyleController = this.layoutMain;
            this.boxClients.TabIndex = 5;
            this.boxClients.SelectedIndexChanged += new System.EventHandler(this.BoxClients_SelectedIndexChanged);
            // 
            // boxCmd
            // 
            this.boxCmd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.boxCmd.Appearance.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.boxCmd.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.boxCmd.Appearance.Options.UseBackColor = true;
            this.boxCmd.Appearance.Options.UseFont = true;
            this.boxCmd.Appearance.Options.UseForeColor = true;
            this.boxCmd.Location = new System.Drawing.Point(204, 36);
            this.boxCmd.Name = "boxCmd";
            this.boxCmd.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.boxCmd.Size = new System.Drawing.Size(536, 343);
            this.boxCmd.StyleController = this.layoutMain;
            this.boxCmd.TabIndex = 4;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 574);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(78, 26);
            this.buttonDisconnect.StyleController = this.layoutMain;
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // buttonDisconnectAll
            // 
            this.buttonDisconnectAll.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.buttonDisconnectAll.Appearance.Options.UseForeColor = true;
            this.buttonDisconnectAll.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.buttonDisconnectAll.AppearanceDisabled.Options.UseForeColor = true;
            this.buttonDisconnectAll.Enabled = false;
            this.buttonDisconnectAll.Location = new System.Drawing.Point(94, 574);
            this.buttonDisconnectAll.Name = "buttonDisconnectAll";
            this.buttonDisconnectAll.Size = new System.Drawing.Size(96, 26);
            this.buttonDisconnectAll.StyleController = this.layoutMain;
            this.buttonDisconnectAll.TabIndex = 7;
            this.buttonDisconnectAll.Text = "Disconnect all";
            this.buttonDisconnectAll.Click += new System.EventHandler(this.ButtonDisconnectAll_Click);
            // 
            // boxMess
            // 
            this.boxMess.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.boxMess.Appearance.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.boxMess.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.boxMess.Appearance.Options.UseBackColor = true;
            this.boxMess.Appearance.Options.UseFont = true;
            this.boxMess.Appearance.Options.UseForeColor = true;
            this.boxMess.Location = new System.Drawing.Point(204, 417);
            this.boxMess.Name = "boxMess";
            this.boxMess.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.boxMess.Size = new System.Drawing.Size(536, 183);
            this.boxMess.StyleController = this.layoutMain;
            this.boxMess.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutClients,
            this.layoutDisconnect,
            this.layoutDisconnectAll,
            this.splitterItem1,
            this.layoutCmd,
            this.layoutMess,
            this.splitterItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(752, 612);
            this.Root.TextVisible = false;
            // 
            // layoutClients
            // 
            this.layoutClients.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutClients.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutClients.Control = this.boxClients;
            this.layoutClients.Location = new System.Drawing.Point(0, 0);
            this.layoutClients.Name = "layoutClients";
            this.layoutClients.Size = new System.Drawing.Size(182, 562);
            this.layoutClients.Text = "Clients";
            this.layoutClients.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutClients.TextSize = new System.Drawing.Size(65, 21);
            // 
            // layoutDisconnect
            // 
            this.layoutDisconnect.Control = this.buttonDisconnect;
            this.layoutDisconnect.Location = new System.Drawing.Point(0, 562);
            this.layoutDisconnect.Name = "layoutDisconnect";
            this.layoutDisconnect.Size = new System.Drawing.Size(82, 30);
            this.layoutDisconnect.TextSize = new System.Drawing.Size(0, 0);
            this.layoutDisconnect.TextVisible = false;
            // 
            // layoutDisconnectAll
            // 
            this.layoutDisconnectAll.Control = this.buttonDisconnectAll;
            this.layoutDisconnectAll.Location = new System.Drawing.Point(82, 562);
            this.layoutDisconnectAll.Name = "layoutDisconnectAll";
            this.layoutDisconnectAll.Size = new System.Drawing.Size(100, 30);
            this.layoutDisconnectAll.TextSize = new System.Drawing.Size(0, 0);
            this.layoutDisconnectAll.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(182, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 592);
            // 
            // layoutCmd
            // 
            this.layoutCmd.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutCmd.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutCmd.Control = this.boxCmd;
            this.layoutCmd.Location = new System.Drawing.Point(192, 0);
            this.layoutCmd.Name = "layoutCmd";
            this.layoutCmd.Size = new System.Drawing.Size(540, 371);
            this.layoutCmd.Text = "Command";
            this.layoutCmd.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutCmd.TextSize = new System.Drawing.Size(65, 21);
            // 
            // layoutMess
            // 
            this.layoutMess.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutMess.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutMess.Control = this.boxMess;
            this.layoutMess.Location = new System.Drawing.Point(192, 381);
            this.layoutMess.Name = "layoutMess";
            this.layoutMess.Size = new System.Drawing.Size(540, 211);
            this.layoutMess.Text = "Message";
            this.layoutMess.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutMess.TextSize = new System.Drawing.Size(65, 21);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(192, 371);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(540, 10);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 612);
            this.Controls.Add(this.layoutMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatapp Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Shown += new System.EventHandler(this.Server_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl boxClients;
        private DevExpress.XtraEditors.ListBoxControl boxCmd;
        private DevExpress.XtraLayout.LayoutControlItem layoutCmd;
        private DevExpress.XtraLayout.LayoutControlItem layoutClients;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SimpleButton buttonDisconnect;
        private DevExpress.XtraEditors.SimpleButton buttonDisconnectAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutDisconnect;
        private DevExpress.XtraLayout.LayoutControlItem layoutDisconnectAll;
        private DevExpress.XtraEditors.ListBoxControl boxMess;
        private DevExpress.XtraLayout.LayoutControlItem layoutMess;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
    }
}

