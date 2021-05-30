using Chatapp.Core.Model;
using System.Linq;
using System.Net.Sockets;

namespace Chatapp.Server.Model {
  public class Client {
    public User User { get; private set; }
    public Socket Socket { get; private set; }
    public State.Client State { get; private set; }

    public Client(Socket socket) {
      this.User = null;
      this.Socket = socket;
      this.State = Model.State.Client.Connecting;
    }

    public string Name { get => this.Socket.RemoteEndPoint.ToString() + ((this.User != null) ? (" - " + this.User.Username) : ""); }

    public bool Authenticate(string username, string password) {
      using (var database = new ChatappEntities()) {
        var user = database.Users.Where(a => a.Username == username).FirstOrDefault();
        if (user == null) {
          return false;
        }

        if (!BCrypt.Net.BCrypt.Verify(password, user.Password)) {
          return false;
        }

        this.User = user;
        this.State = Model.State.Client.Ready;
        return true;
      }
    }

    public void Disconnect() {
      this.User = null;
      if (this.Socket != null) {
        this.Socket.Close();
        this.Socket.Dispose();
      }
      this.State = Model.State.Client.Disconnected;
    }
  }
}
