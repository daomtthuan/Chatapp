namespace Chatapp.Core.Model.Data {
  public class JoinData : IData {
    public User User { get; private set; }

    public JoinData(User user) {
      this.User = user;
    }
  }
}
