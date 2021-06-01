
namespace Chatapp.ChatappServer.Views.Forms {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.clientsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
      this.clientsListLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.startSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.stopSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.disconnectSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.actionsLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.profileSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.titleControl = new Chatapp.ChatappServer.Views.Controls.TitleControl();
      this.clientsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.managementLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.logoutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.clientsListBoxControl)).BeginInit();
      this.SuspendLayout();
      // 
      // clientsListBoxControl
      // 
      this.clientsListBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.clientsListBoxControl.Location = new System.Drawing.Point(14, 106);
      this.clientsListBoxControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.clientsListBoxControl.Name = "clientsListBoxControl";
      this.clientsListBoxControl.Size = new System.Drawing.Size(299, 318);
      this.clientsListBoxControl.TabIndex = 1;
      this.clientsListBoxControl.SelectedIndexChanged += new System.EventHandler(this.ClientsListBoxControl_SelectedIndexChanged);
      // 
      // clientsListLabelControl
      // 
      this.clientsListLabelControl.Location = new System.Drawing.Point(14, 82);
      this.clientsListLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.clientsListLabelControl.Name = "clientsListLabelControl";
      this.clientsListLabelControl.Size = new System.Drawing.Size(58, 16);
      this.clientsListLabelControl.TabIndex = 0;
      this.clientsListLabelControl.Text = "Clients list";
      // 
      // startSimpleButton
      // 
      this.startSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.startSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.startSimpleButton.Appearance.Options.UseBackColor = true;
      this.startSimpleButton.Location = new System.Drawing.Point(319, 106);
      this.startSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.startSimpleButton.Name = "startSimpleButton";
      this.startSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.startSimpleButton.TabIndex = 2;
      this.startSimpleButton.Text = "Start";
      this.startSimpleButton.Click += new System.EventHandler(this.StartSimpleButton_Click);
      // 
      // stopSimpleButton
      // 
      this.stopSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.stopSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
      this.stopSimpleButton.Appearance.Options.UseBackColor = true;
      this.stopSimpleButton.Enabled = false;
      this.stopSimpleButton.Location = new System.Drawing.Point(319, 141);
      this.stopSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.stopSimpleButton.Name = "stopSimpleButton";
      this.stopSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.stopSimpleButton.TabIndex = 3;
      this.stopSimpleButton.Text = "Stop";
      // 
      // disconnectSimpleButton
      // 
      this.disconnectSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.disconnectSimpleButton.Enabled = false;
      this.disconnectSimpleButton.Location = new System.Drawing.Point(319, 177);
      this.disconnectSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.disconnectSimpleButton.Name = "disconnectSimpleButton";
      this.disconnectSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.disconnectSimpleButton.TabIndex = 4;
      this.disconnectSimpleButton.Text = "Disconnect";
      // 
      // actionsLabelControl
      // 
      this.actionsLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.actionsLabelControl.Location = new System.Drawing.Point(319, 82);
      this.actionsLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.actionsLabelControl.Name = "actionsLabelControl";
      this.actionsLabelControl.Size = new System.Drawing.Size(41, 16);
      this.actionsLabelControl.TabIndex = 0;
      this.actionsLabelControl.Text = "Actions";
      // 
      // profileSimpleButton
      // 
      this.profileSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.profileSimpleButton.Location = new System.Drawing.Point(319, 234);
      this.profileSimpleButton.Name = "profileSimpleButton";
      this.profileSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.profileSimpleButton.TabIndex = 5;
      this.profileSimpleButton.Text = "Server Profile";
      this.profileSimpleButton.Click += new System.EventHandler(this.ProfileSimpleButton_Click);
      // 
      // titleControl
      // 
      this.titleControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.titleControl.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.titleControl.Appearance.Options.UseBackColor = true;
      this.titleControl.AutoSize = true;
      this.titleControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.titleControl.Location = new System.Drawing.Point(146, 14);
      this.titleControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.titleControl.Name = "titleControl";
      this.titleControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.titleControl.Size = new System.Drawing.Size(158, 61);
      this.titleControl.TabIndex = 0;
      // 
      // clientsSimpleButton
      // 
      this.clientsSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.clientsSimpleButton.Location = new System.Drawing.Point(319, 268);
      this.clientsSimpleButton.Name = "clientsSimpleButton";
      this.clientsSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.clientsSimpleButton.TabIndex = 6;
      this.clientsSimpleButton.Text = "Clients profile";
      this.clientsSimpleButton.Click += new System.EventHandler(this.ClientsSimpleButton_Click);
      // 
      // managementLabelControl
      // 
      this.managementLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.managementLabelControl.Location = new System.Drawing.Point(319, 212);
      this.managementLabelControl.Name = "managementLabelControl";
      this.managementLabelControl.Size = new System.Drawing.Size(74, 16);
      this.managementLabelControl.TabIndex = 7;
      this.managementLabelControl.Text = "Management";
      // 
      // logoutSimpleButton
      // 
      this.logoutSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.logoutSimpleButton.Location = new System.Drawing.Point(319, 302);
      this.logoutSimpleButton.Name = "logoutSimpleButton";
      this.logoutSimpleButton.Size = new System.Drawing.Size(117, 28);
      this.logoutSimpleButton.TabIndex = 8;
      this.logoutSimpleButton.Text = "Logout";
      this.logoutSimpleButton.Click += new System.EventHandler(this.LogoutSimpleButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(448, 438);
      this.Controls.Add(this.logoutSimpleButton);
      this.Controls.Add(this.managementLabelControl);
      this.Controls.Add(this.clientsSimpleButton);
      this.Controls.Add(this.profileSimpleButton);
      this.Controls.Add(this.actionsLabelControl);
      this.Controls.Add(this.disconnectSimpleButton);
      this.Controls.Add(this.stopSimpleButton);
      this.Controls.Add(this.startSimpleButton);
      this.Controls.Add(this.clientsListLabelControl);
      this.Controls.Add(this.clientsListBoxControl);
      this.Controls.Add(this.titleControl);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MinimumSize = new System.Drawing.Size(450, 470);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chatapp Server";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.clientsListBoxControl)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Controls.TitleControl titleControl;
    private DevExpress.XtraEditors.ListBoxControl clientsListBoxControl;
    private DevExpress.XtraEditors.LabelControl clientsListLabelControl;
    private DevExpress.XtraEditors.SimpleButton startSimpleButton;
    private DevExpress.XtraEditors.SimpleButton stopSimpleButton;
    private DevExpress.XtraEditors.SimpleButton disconnectSimpleButton;
    private DevExpress.XtraEditors.LabelControl actionsLabelControl;
    private DevExpress.XtraEditors.SimpleButton profileSimpleButton;
    private DevExpress.XtraEditors.SimpleButton clientsSimpleButton;
    private DevExpress.XtraEditors.LabelControl managementLabelControl;
    private DevExpress.XtraEditors.SimpleButton logoutSimpleButton;
  }
}