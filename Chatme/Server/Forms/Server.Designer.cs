namespace Server.Forms
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listboxConnectedClients = new DevExpress.XtraEditors.ListBoxControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelTitle = new DevExpress.XtraLayout.SimpleLabelItem();
            this.labelListConnectedClients = new DevExpress.XtraLayout.SimpleLabelItem();
            this.labelAdministrator = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listboxConnectedClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelListConnectedClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelAdministrator)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.listboxConnectedClients);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(435, 642);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listboxConnectedClients
            // 
            this.listboxConnectedClients.Location = new System.Drawing.Point(12, 99);
            this.listboxConnectedClients.Name = "listboxConnectedClients";
            this.listboxConnectedClients.Size = new System.Drawing.Size(411, 531);
            this.listboxConnectedClients.StyleController = this.layoutControl1;
            this.listboxConnectedClients.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.labelTitle,
            this.labelListConnectedClients,
            this.labelAdministrator});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(435, 642);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listboxConnectedClients;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(415, 535);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AllowHotTrack = false;
            this.labelTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Lexend Deca", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.AppearanceItemCaption.Options.UseFont = true;
            this.labelTitle.AppearanceItemCaption.Options.UseTextOptions = true;
            this.labelTitle.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(415, 37);
            this.labelTitle.Text = "Chatme Server";
            this.labelTitle.TextSize = new System.Drawing.Size(150, 33);
            // 
            // labelListConnectedClients
            // 
            this.labelListConnectedClients.AllowHotTrack = false;
            this.labelListConnectedClients.Location = new System.Drawing.Point(0, 62);
            this.labelListConnectedClients.Name = "labelListConnectedClients";
            this.labelListConnectedClients.Size = new System.Drawing.Size(415, 25);
            this.labelListConnectedClients.Text = "Connected Clients";
            this.labelListConnectedClients.TextSize = new System.Drawing.Size(150, 21);
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AllowHotTrack = false;
            this.labelAdministrator.Location = new System.Drawing.Point(0, 37);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(415, 25);
            this.labelAdministrator.Text = "Administrator: ";
            this.labelAdministrator.TextSize = new System.Drawing.Size(150, 21);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 642);
            this.Controls.Add(this.layoutControl1);
            this.Icon = global::Server.Properties.Resources.Server;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listboxConnectedClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelListConnectedClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelAdministrator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ListBoxControl listboxConnectedClients;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem labelTitle;
        private DevExpress.XtraLayout.SimpleLabelItem labelListConnectedClients;
        private DevExpress.XtraLayout.SimpleLabelItem labelAdministrator;
    }
}