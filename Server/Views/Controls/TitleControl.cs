using DevExpress.XtraEditors;
using System.Reflection;

namespace Chatapp.ChatappServer.Views.Controls {
  public partial class TitleControl : XtraUserControl {
    public TitleControl() {
      InitializeComponent();
    }

    private void TitleControl_Load(object sender, System.EventArgs e) {
      versionLabelControl.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version}";
    }
  }
}
