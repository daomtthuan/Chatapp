using Chatapp.ChatappServer.Models;
using System.Linq;
using System.Net.Sockets;

namespace Chatapp.ChatappServer.App {
  class Client {
    private readonly ChatappEntities _entities;

    public int Id { get; private set; }
    public int InformationId { get; private set; }
    public string Username { get; private set; }
    public string Name { get; private set; }
    public Socket Socket { get; private set; }
    public ClientState State { get; private set; }

    public Client(Socket socket) {
      _entities = new ChatappEntities();
      Id = 0;
      InformationId = 0;
      Username = null;
      Name = null;
      Socket = socket;
      State = ClientState.Connecting;
    }

    public bool Login(string username, string password) {
      var account = _entities.Users.Where(a => a.Username == username).FirstOrDefault();
      if (account == null) {
        return false;
      }
      if (!BCrypt.Net.BCrypt.Verify(password, account.Password)) {
        return false;
      }
      Id = account.Id;
      InformationId = account.InformationId;
      Username = account.Username;
      Name = Socket.RemoteEndPoint + " - " + account.Username;
      return true;
    }

    public void Logout() {
      Id = 0;
      InformationId = 0;
      Username = null;
      Name = null;
      if (Socket != null) {
        Socket.Close();
        Socket.Dispose();
      }
      State = ClientState.Disconnected;
    }
  }
}
