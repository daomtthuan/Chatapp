namespace Chatapp.Core.Model.Data {
  public class LeaveData : IData {
    public User User { get; private set; }

    public LeaveData(User user) {
      this.User = user;
    }
  }
}
