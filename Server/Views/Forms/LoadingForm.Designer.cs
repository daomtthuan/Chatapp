
namespace Chatapp.ChatappServer.Views.Forms {
  partial class LoadingForm {
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
      this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      this.copyrighLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.statusLabelControl = new DevExpress.XtraEditors.LabelControl();
      this.titleControl1 = new Chatapp.ChatappServer.Views.Controls.TitleControl();
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBarControl
      // 
      this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarControl.EditValue = 0;
      this.progressBarControl.Location = new System.Drawing.Point(5, 94);
      this.progressBarControl.Name = "progressBarControl";
      this.progressBarControl.Size = new System.Drawing.Size(421, 8);
      this.progressBarControl.TabIndex = 5;
      // 
      // copyrighLabelControl
      // 
      this.copyrighLabelControl.Location = new System.Drawing.Point(251, 107);
      this.copyrighLabelControl.Margin = new System.Windows.Forms.Padding(2);
      this.copyrighLabelControl.Name = "copyrighLabelControl";
      this.copyrighLabelControl.Size = new System.Drawing.Size(175, 16);
      this.copyrighLabelControl.TabIndex = 7;
      this.copyrighLabelControl.Text = "Copyright © Daomtthuan 2021";
      // 
      // statusLabelControl
      // 
      this.statusLabelControl.Location = new System.Drawing.Point(5, 76);
      this.statusLabelControl.Margin = new System.Windows.Forms.Padding(2);
      this.statusLabelControl.Name = "statusLabelControl";
      this.statusLabelControl.Size = new System.Drawing.Size(54, 16);
      this.statusLabelControl.TabIndex = 8;
      this.statusLabelControl.Text = "Startup...";
      // 
      // titleControl1
      // 
      this.titleControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.titleControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.titleControl1.Appearance.Options.UseBackColor = true;
      this.titleControl1.AutoSize = true;
      this.titleControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.titleControl1.Location = new System.Drawing.Point(137, 5);
      this.titleControl1.Margin = new System.Windows.Forms.Padding(2);
      this.titleControl1.Name = "titleControl1";
      this.titleControl1.Padding = new System.Windows.Forms.Padding(2);
      this.titleControl1.Size = new System.Drawing.Size(157, 61);
      this.titleControl1.TabIndex = 9;
      // 
      // LoadingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 138);
      this.Controls.Add(this.titleControl1);
      this.Controls.Add(this.statusLabelControl);
      this.Controls.Add(this.copyrighLabelControl);
      this.Controls.Add(this.progressBarControl);
      this.Name = "LoadingForm";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Text = "Chatapp Server - Loading";
      this.Load += new System.EventHandler(this.LoadingForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
    private DevExpress.XtraEditors.LabelControl copyrighLabelControl;
    private DevExpress.XtraEditors.LabelControl statusLabelControl;
    private Controls.TitleControl titleControl1;
  }
}
