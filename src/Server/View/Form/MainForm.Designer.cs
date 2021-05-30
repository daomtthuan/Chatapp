
namespace Chatapp.Server.View.Form {
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
      this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
      this.titleControl = new Chatapp.Server.View.Control.TitleControl();
      this.clientsListLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.startSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.stopSimpleButton = new DevExpress.XtraEditors.SimpleButton();
      this.disconnetSimpleButton3 = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // listBoxControl1
      // 
      this.listBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBoxControl1.Location = new System.Drawing.Point(12, 87);
      this.listBoxControl1.Name = "listBoxControl1";
      this.listBoxControl1.Size = new System.Drawing.Size(309, 465);
      this.listBoxControl1.TabIndex = 0;
      // 
      // titleControl
      // 
      this.titleControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.titleControl.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.titleControl.Appearance.Options.UseBackColor = true;
      this.titleControl.AutoSize = true;
      this.titleControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.titleControl.Location = new System.Drawing.Point(153, 12);
      this.titleControl.Name = "titleControl";
      this.titleControl.Padding = new System.Windows.Forms.Padding(3);
      this.titleControl.Size = new System.Drawing.Size(138, 50);
      this.titleControl.TabIndex = 1;
      // 
      // clientsListLabelControl
      // 
      this.clientsListLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.clientsListLabelControl.Appearance.Options.UseFont = true;
      this.clientsListLabelControl.Location = new System.Drawing.Point(12, 68);
      this.clientsListLabelControl.Name = "clientsListLabelControl";
      this.clientsListLabelControl.Size = new System.Drawing.Size(58, 13);
      this.clientsListLabelControl.TabIndex = 2;
      this.clientsListLabelControl.Text = "Clients list";
      // 
      // startSimpleButton
      // 
      this.startSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.startSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.startSimpleButton.Appearance.Options.UseBackColor = true;
      this.startSimpleButton.Location = new System.Drawing.Point(332, 87);
      this.startSimpleButton.Name = "startSimpleButton";
      this.startSimpleButton.Size = new System.Drawing.Size(100, 23);
      this.startSimpleButton.TabIndex = 3;
      this.startSimpleButton.Text = "Start";
      // 
      // stopSimpleButton
      // 
      this.stopSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.stopSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
      this.stopSimpleButton.Appearance.Options.UseBackColor = true;
      this.stopSimpleButton.Enabled = false;
      this.stopSimpleButton.Location = new System.Drawing.Point(332, 116);
      this.stopSimpleButton.Name = "stopSimpleButton";
      this.stopSimpleButton.Size = new System.Drawing.Size(100, 23);
      this.stopSimpleButton.TabIndex = 4;
      this.stopSimpleButton.Text = "Stop";
      // 
      // disconnetSimpleButton3
      // 
      this.disconnetSimpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.disconnetSimpleButton3.Location = new System.Drawing.Point(332, 529);
      this.disconnetSimpleButton3.Name = "disconnetSimpleButton3";
      this.disconnetSimpleButton3.Size = new System.Drawing.Size(100, 23);
      this.disconnetSimpleButton3.TabIndex = 5;
      this.disconnetSimpleButton3.Text = "Disconnet";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(444, 564);
      this.Controls.Add(this.disconnetSimpleButton3);
      this.Controls.Add(this.stopSimpleButton);
      this.Controls.Add(this.startSimpleButton);
      this.Controls.Add(this.clientsListLabelControl);
      this.Controls.Add(this.titleControl);
      this.Controls.Add(this.listBoxControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chatapp Server 2.0";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    private Control.TitleControl titleControl;
    private DevExpress.XtraEditors.LabelControl clientsListLabelControl;
    private DevExpress.XtraEditors.SimpleButton startSimpleButton;
    private DevExpress.XtraEditors.SimpleButton stopSimpleButton;
    private DevExpress.XtraEditors.SimpleButton disconnetSimpleButton3;
  }
}