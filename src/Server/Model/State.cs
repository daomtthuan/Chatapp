namespace Chatapp.Server.Model {
  public class State {
    public enum Client {
      Connecting,
      Ready,
      Disconnected,
    }

    public enum Server {
      Ready,
      Stopped,
    }
  }
}
