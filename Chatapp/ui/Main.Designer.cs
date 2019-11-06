namespace Chatapp.ui
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.onlineListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.sendSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.messageTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // onlineListBoxControl
            // 
            this.onlineListBoxControl.Location = new System.Drawing.Point(12, 12);
            this.onlineListBoxControl.Name = "onlineListBoxControl";
            this.onlineListBoxControl.Size = new System.Drawing.Size(237, 461);
            this.onlineListBoxControl.TabIndex = 0;
            this.onlineListBoxControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnlineListBoxControl_MouseClick);
            // 
            // sendSimpleButton
            // 
            this.sendSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sendSimpleButton.Appearance.Options.UseBackColor = true;
            this.sendSimpleButton.Location = new System.Drawing.Point(663, 437);
            this.sendSimpleButton.Name = "sendSimpleButton";
            this.sendSimpleButton.Size = new System.Drawing.Size(122, 36);
            this.sendSimpleButton.TabIndex = 2;
            this.sendSimpleButton.Text = "Send";
            this.sendSimpleButton.Click += new System.EventHandler(this.SendSimpleButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(255, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(530, 385);
            this.tabControl.TabIndex = 3;
            this.tabControl.CloseButtonClick += new System.EventHandler(this.TabControl_CloseButtonClick);
            // 
            // messageTextEdit
            // 
            this.messageTextEdit.Location = new System.Drawing.Point(255, 403);
            this.messageTextEdit.Name = "messageTextEdit";
            this.messageTextEdit.Size = new System.Drawing.Size(530, 28);
            this.messageTextEdit.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 485);
            this.Controls.Add(this.messageTextEdit);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.sendSimpleButton);
            this.Controls.Add(this.onlineListBoxControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatapp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.onlineListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl onlineListBoxControl;
        private DevExpress.XtraEditors.SimpleButton sendSimpleButton;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraEditors.TextEdit messageTextEdit;
    }
}