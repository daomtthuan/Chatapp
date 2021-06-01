namespace Chatapp.ChatappCore.DataHelpers.Data {
  public class RequestLoginData : IData {
    public string Username { get; private set; }
    public string Password { get; private set; }

    public RequestLoginData(string username, string password) {
      Username = username;
      Password = password;
    }
  }
}
