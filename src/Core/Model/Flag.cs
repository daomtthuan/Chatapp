namespace Chatapp.Core.Model {
  public class Flag {
    public enum Client {
      AuthRequest,
      Disconnect,
      SendText,
    }

    public enum Server {
      AuthResponse,
      UserJoin,
      UserLeave,
      SendText,
      SendResponse
    }
  }
}
