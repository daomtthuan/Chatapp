namespace Server.ui
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.accountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.loginLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.titleSimpleLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            this.passwordLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.accountLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleSimpleLabelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.accountTextEdit);
            this.layoutControl.Controls.Add(this.passwordTextEdit);
            this.layoutControl.Controls.Add(this.loginSimpleButton);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(315, 193);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // accountTextEdit
            // 
            this.accountTextEdit.Location = new System.Drawing.Point(12, 71);
            this.accountTextEdit.Name = "accountTextEdit";
            this.accountTextEdit.Size = new System.Drawing.Size(291, 22);
            this.accountTextEdit.StyleController = this.layoutControl;
            this.accountTextEdit.TabIndex = 4;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(12, 116);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(291, 22);
            this.passwordTextEdit.StyleController = this.layoutControl;
            this.passwordTextEdit.TabIndex = 5;
            // 
            // loginSimpleButton
            // 
            this.loginSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.loginSimpleButton.Appearance.Options.UseBackColor = true;
            this.loginSimpleButton.Location = new System.Drawing.Point(12, 159);
            this.loginSimpleButton.Name = "loginSimpleButton";
            this.loginSimpleButton.Size = new System.Drawing.Size(291, 22);
            this.loginSimpleButton.StyleController = this.layoutControl;
            this.loginSimpleButton.TabIndex = 6;
            this.loginSimpleButton.Text = "Login";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.loginLayoutControlItem,
            this.titleSimpleLabelItem,
            this.passwordLayoutControlItem,
            this.accountLayoutControlItem,
            this.emptySpaceItem,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(315, 193);
            this.Root.TextVisible = false;
            // 
            // loginLayoutControlItem
            // 
            this.loginLayoutControlItem.Control = this.loginSimpleButton;
            this.loginLayoutControlItem.Location = new System.Drawing.Point(0, 147);
            this.loginLayoutControlItem.Name = "loginLayoutControlItem";
            this.loginLayoutControlItem.Size = new System.Drawing.Size(295, 26);
            this.loginLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.loginLayoutControlItem.TextVisible = false;
            // 
            // titleSimpleLabelItem
            // 
            this.titleSimpleLabelItem.AllowHotTrack = false;
            this.titleSimpleLabelItem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSimpleLabelItem.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.titleSimpleLabelItem.AppearanceItemCaption.Options.UseFont = true;
            this.titleSimpleLabelItem.AppearanceItemCaption.Options.UseForeColor = true;
            this.titleSimpleLabelItem.AppearanceItemCaption.Options.UseTextOptions = true;
            this.titleSimpleLabelItem.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleSimpleLabelItem.Location = new System.Drawing.Point(0, 0);
            this.titleSimpleLabelItem.Name = "titleSimpleLabelItem";
            this.titleSimpleLabelItem.Size = new System.Drawing.Size(295, 23);
            this.titleSimpleLabelItem.Text = "LOGIN SERVER CHATAPP";
            this.titleSimpleLabelItem.TextSize = new System.Drawing.Size(207, 19);
            // 
            // passwordLayoutControlItem
            // 
            this.passwordLayoutControlItem.Control = this.passwordTextEdit;
            this.passwordLayoutControlItem.Location = new System.Drawing.Point(0, 85);
            this.passwordLayoutControlItem.Name = "passwordLayoutControlItem";
            this.passwordLayoutControlItem.Size = new System.Drawing.Size(295, 45);
            this.passwordLayoutControlItem.Text = "Password";
            this.passwordLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.passwordLayoutControlItem.TextSize = new System.Drawing.Size(207, 16);
            // 
            // accountLayoutControlItem
            // 
            this.accountLayoutControlItem.Control = this.accountTextEdit;
            this.accountLayoutControlItem.Location = new System.Drawing.Point(0, 40);
            this.accountLayoutControlItem.Name = "accountLayoutControlItem";
            this.accountLayoutControlItem.Size = new System.Drawing.Size(295, 45);
            this.accountLayoutControlItem.Text = "Account";
            this.accountLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.accountLayoutControlItem.TextSize = new System.Drawing.Size(207, 16);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 130);
            this.emptySpaceItem.MaxSize = new System.Drawing.Size(295, 17);
            this.emptySpaceItem.MinSize = new System.Drawing.Size(295, 17);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(295, 17);
            this.emptySpaceItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(295, 17);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(295, 17);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(295, 17);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Login
            // 
            this.AcceptButton = this.loginSimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 193);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleSimpleLabelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit accountTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.SimpleButton loginSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem loginLayoutControlItem;
        private DevExpress.XtraLayout.SimpleLabelItem titleSimpleLabelItem;
        private DevExpress.XtraLayout.LayoutControlItem passwordLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem accountLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}