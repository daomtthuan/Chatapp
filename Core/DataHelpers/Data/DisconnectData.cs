namespace Chatapp.ChatappCore.DataHelpers.Data {
  public class DisconnectData : IData {
    public string Username { get; private set; }

    public DisconnectData(string username) {
      Username = username;
    }
  }
}
