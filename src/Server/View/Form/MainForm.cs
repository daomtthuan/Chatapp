using System.Windows.Forms;

namespace Chatapp.Server.View.Form {
  public partial class MainForm : DevExpress.XtraEditors.XtraForm {
    public Server Server { get; private set; }

    public MainForm() {
      this.InitializeComponent();
    }

    private void MainForm_Load(object sender, System.EventArgs e) {
      var loginForm = new LoginForm(this);
      if (loginForm.ShowDialog() != DialogResult.OK) {
        Application.Exit();
        return;
      }

      this.Server = new Model.Server();
      this.Visible = true;
    }
  }
}
