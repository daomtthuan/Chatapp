namespace Chatapp.ChatappCore.DataHelpers {
  public enum MessageFlag {
    ClientRequestLogin, // Client request login to server
    ClientDisconnect, // Client disconnect Server

    ServerResponseLogin, // Server response when Client request login to server
    ServerDisconnect, // Server disconnect Client
  }
}
