namespace Chatapp.Server.Helper {
  internal static class RegexPattern {
    public const string USERNAME = "\\w{1,100}";
    public const string PASSWORD = ".{1,100}";
  }
}
