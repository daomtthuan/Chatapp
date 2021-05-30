namespace Chatapp.Core.Model.Data {
  public class SendTextData : IData {
    public User User { get; private set; }
    public string Text { get; private set; }

    public SendTextData(User user, string text) {
      this.User = user;
      this.Text = text;
    }
  }
}
