
namespace Chatapp.Server.View.Control {
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
      this.nameLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabelControl.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.nameLabelControl.Appearance.Options.UseFont = true;
      this.nameLabelControl.Appearance.Options.UseForeColor = true;
      this.nameLabelControl.Location = new System.Drawing.Point(6, 6);
      this.nameLabelControl.Name = "nameLabelControl";
      this.nameLabelControl.Size = new System.Drawing.Size(126, 19);
      this.nameLabelControl.TabIndex = 0;
      this.nameLabelControl.Text = "Chatapp Server";
      // 
      // versionLabelControl
      // 
      this.versionLabelControl.Location = new System.Drawing.Point(42, 31);
      this.versionLabelControl.Name = "versionLabelControl";
      this.versionLabelControl.Size = new System.Drawing.Size(54, 13);
      this.versionLabelControl.TabIndex = 1;
      this.versionLabelControl.Text = "Version 2.0";
      // 
      // TitleControl
      // 
      this.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.versionLabelControl);
      this.Controls.Add(this.nameLabelControl);
      this.Name = "TitleControl";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Size = new System.Drawing.Size(138, 50);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl nameLabelControl;
    private DevExpress.XtraEditors.LabelControl versionLabelControl;
  }
}
