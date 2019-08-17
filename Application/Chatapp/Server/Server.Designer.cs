﻿namespace Server
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
            this.boxMessage = new DevExpress.XtraEditors.MemoEdit();
            this.boxCommand = new DevExpress.XtraEditors.MemoEdit();
            this.boxClients = new DevExpress.XtraEditors.ListBoxControl();
            this.buttonDisconnect = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDisconnectAll = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutClients = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutCommad = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutDisconnect = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDisconnectAll = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).BeginInit();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCommand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCommad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnectAll)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AllowCustomization = false;
            this.layoutMain.Controls.Add(this.boxMessage);
            this.layoutMain.Controls.Add(this.boxCommand);
            this.layoutMain.Controls.Add(this.boxClients);
            this.layoutMain.Controls.Add(this.buttonDisconnect);
            this.layoutMain.Controls.Add(this.buttonDisconnectAll);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1053, 350, 650, 400);
            this.layoutMain.Root = this.Root;
            this.layoutMain.Size = new System.Drawing.Size(752, 612);
            this.layoutMain.TabIndex = 0;
            this.layoutMain.Text = "layoutControl1";
            // 
            // boxMessage
            // 
            this.boxMessage.EditValue = "";
            this.boxMessage.Location = new System.Drawing.Point(12, 494);
            this.boxMessage.Name = "boxMessage";
            this.boxMessage.Properties.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.boxMessage.Properties.Appearance.Font = new System.Drawing.Font("Source Code Pro", 8.25F);
            this.boxMessage.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.boxMessage.Properties.Appearance.Options.UseBackColor = true;
            this.boxMessage.Properties.Appearance.Options.UseFont = true;
            this.boxMessage.Properties.Appearance.Options.UseForeColor = true;
            this.boxMessage.Properties.ReadOnly = true;
            this.boxMessage.Size = new System.Drawing.Size(728, 106);
            this.boxMessage.StyleController = this.layoutMain;
            this.boxMessage.TabIndex = 9;
            // 
            // boxCommand
            // 
            this.boxCommand.EditValue = "";
            this.boxCommand.Location = new System.Drawing.Point(215, 36);
            this.boxCommand.Name = "boxCommand";
            this.boxCommand.Properties.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.boxCommand.Properties.Appearance.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCommand.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.boxCommand.Properties.Appearance.Options.UseBackColor = true;
            this.boxCommand.Properties.Appearance.Options.UseFont = true;
            this.boxCommand.Properties.Appearance.Options.UseForeColor = true;
            this.boxCommand.Properties.ReadOnly = true;
            this.boxCommand.Size = new System.Drawing.Size(525, 420);
            this.boxCommand.StyleController = this.layoutMain;
            this.boxCommand.TabIndex = 8;
            // 
            // boxClients
            // 
            this.boxClients.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.boxClients.Location = new System.Drawing.Point(12, 36);
            this.boxClients.Name = "boxClients";
            this.boxClients.Size = new System.Drawing.Size(189, 360);
            this.boxClients.StyleController = this.layoutMain;
            this.boxClients.TabIndex = 5;
            this.boxClients.SelectedIndexChanged += new System.EventHandler(this.BoxClients_SelectedIndexChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 400);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(189, 26);
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
            this.buttonDisconnectAll.Location = new System.Drawing.Point(12, 430);
            this.buttonDisconnectAll.Name = "buttonDisconnectAll";
            this.buttonDisconnectAll.Size = new System.Drawing.Size(189, 26);
            this.buttonDisconnectAll.StyleController = this.layoutMain;
            this.buttonDisconnectAll.TabIndex = 7;
            this.buttonDisconnectAll.Text = "Disconnect all";
            this.buttonDisconnectAll.Click += new System.EventHandler(this.ButtonDisconnectAll_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutClients,
            this.splitterItem1,
            this.layoutCommad,
            this.layoutMessage,
            this.splitterItem2,
            this.layoutDisconnect,
            this.layoutDisconnectAll});
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
            this.layoutClients.Size = new System.Drawing.Size(193, 388);
            this.layoutClients.Text = "Clients";
            this.layoutClients.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutClients.TextSize = new System.Drawing.Size(65, 21);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(193, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 448);
            // 
            // layoutCommad
            // 
            this.layoutCommad.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutCommad.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutCommad.Control = this.boxCommand;
            this.layoutCommad.Location = new System.Drawing.Point(203, 0);
            this.layoutCommad.Name = "layoutCommad";
            this.layoutCommad.Size = new System.Drawing.Size(529, 448);
            this.layoutCommad.Text = "Command";
            this.layoutCommad.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutCommad.TextSize = new System.Drawing.Size(65, 21);
            // 
            // layoutMessage
            // 
            this.layoutMessage.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutMessage.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutMessage.Control = this.boxMessage;
            this.layoutMessage.Location = new System.Drawing.Point(0, 458);
            this.layoutMessage.Name = "layoutMessage";
            this.layoutMessage.Size = new System.Drawing.Size(732, 134);
            this.layoutMessage.Text = "Message";
            this.layoutMessage.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutMessage.TextSize = new System.Drawing.Size(65, 21);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 448);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(732, 10);
            // 
            // layoutDisconnect
            // 
            this.layoutDisconnect.Control = this.buttonDisconnect;
            this.layoutDisconnect.Location = new System.Drawing.Point(0, 388);
            this.layoutDisconnect.Name = "layoutDisconnect";
            this.layoutDisconnect.Size = new System.Drawing.Size(193, 30);
            this.layoutDisconnect.TextSize = new System.Drawing.Size(0, 0);
            this.layoutDisconnect.TextVisible = false;
            // 
            // layoutDisconnectAll
            // 
            this.layoutDisconnectAll.Control = this.buttonDisconnectAll;
            this.layoutDisconnectAll.Location = new System.Drawing.Point(0, 418);
            this.layoutDisconnectAll.Name = "layoutDisconnectAll";
            this.layoutDisconnectAll.Size = new System.Drawing.Size(193, 30);
            this.layoutDisconnectAll.TextSize = new System.Drawing.Size(0, 0);
            this.layoutDisconnectAll.TextVisible = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 612);
            this.Controls.Add(this.layoutMain);
            this.Icon = global::Server.Properties.Resources.ServerIcon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatapp Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Shown += new System.EventHandler(this.Server_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutMain)).EndInit();
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCommand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCommad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDisconnectAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl boxClients;
        private DevExpress.XtraLayout.LayoutControlItem layoutClients;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SimpleButton buttonDisconnect;
        private DevExpress.XtraEditors.SimpleButton buttonDisconnectAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutDisconnect;
        private DevExpress.XtraLayout.LayoutControlItem layoutDisconnectAll;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraEditors.MemoEdit boxMessage;
        private DevExpress.XtraEditors.MemoEdit boxCommand;
        private DevExpress.XtraLayout.LayoutControlItem layoutCommad;
        private DevExpress.XtraLayout.LayoutControlItem layoutMessage;
    }
}

