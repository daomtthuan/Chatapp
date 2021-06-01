namespace Chatapp.ChatappCore.DataHelpers.Data {
  public class ResponseLoginData : IData {
    public bool Result { get; private set; }
    public string Username { get; private set; }
    public string FullName { get; private set; }

    public ResponseLoginData(bool result, string username, string fullName) {
      Result = result;
      Username = username;
      FullName = fullName;
    }
  }
}
