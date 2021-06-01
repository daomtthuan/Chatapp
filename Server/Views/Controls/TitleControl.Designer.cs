
namespace Chatapp.ChatappServer.Views.Controls {
  partial class TitleControl {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.versionLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.SuspendLayout();
      // 
      // nameLabelControl
      // 
      this.nameLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabelControl.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.nameLabelControl.Appearance.Options.UseFont = true;
      this.nameLabelControl.Appearance.Options.UseForeColor = true;
      this.nameLabelControl.Location = new System.Drawing.Point(6, 4);
      this.nameLabelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.nameLabelControl.Name = "nameLabelControl";
      this.nameLabelControl.Size = new System.Drawing.Size(146, 23);
      this.nameLabelControl.TabIndex = 0;
      this.nameLabelControl.Text = "Chatapp Server";
      // 
      // versionLabelControl
      // 
      this.versionLabelControl.Appearance.Options.UseTextOptions = true;
      this.versionLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.versionLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.versionLabelControl.Location = new System.Drawing.Point(6, 39);
      this.versionLabelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.versionLabelControl.Name = "versionLabelControl";
      this.versionLabelControl.Size = new System.Drawing.Size(146, 18);
      this.versionLabelControl.TabIndex = 1;
      this.versionLabelControl.Text = "Version 2.0";
      // 
      // TitleControl
      // 
      this.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.versionLabelControl);
      this.Controls.Add(this.nameLabelControl);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "TitleControl";
      this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Size = new System.Drawing.Size(158, 61);
      this.Load += new System.EventHandler(this.TitleControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl nameLabelControl;
    private DevExpress.XtraEditors.LabelControl versionLabelControl;
  }
}
