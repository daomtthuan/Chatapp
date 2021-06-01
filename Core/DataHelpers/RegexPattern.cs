namespace Chatapp.ChatappCore.DataHelpers {
  public class RegexPattern {
    public const string USERNAME = "^(?:\\w){1,100}$";
    public const string PASSWORD = "^(?:.){1,100}$";
    public const string FULL_NAME = "^(?:[a-zA-Z '-]){1,100}$";
    public const string EMAIL = "^(?:[a-z][a-z0-9_\\.]{5,}@[a-z0-9]{2,}(\\.[a-z0-9]{2,4}){1,3}){1,100}$";
    public const string PHONE = "^(?:\\+?\\d{10,}){1,15}$";
    public const string ADDRESS = "^(?:.){1,500}$";
  }
}
