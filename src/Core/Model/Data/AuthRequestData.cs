namespace Chatapp.Core.Model.Data {
  public class AuthRequestData : IData {
    public string Username { get; private set; }
    public string Password { get; private set; }

    public AuthRequestData(string username, string password) {
      this.Username = username;
      this.Password = password;
    }
  }
}
