using Chatapp.Core.Properties;

namespace Chatapp.Core {
  public static class Config {
    public static int Port { get => Settings.Default.Port; }
  }
}
