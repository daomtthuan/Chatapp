using Chatapp.Core;
using Chatapp.Core.Helper.Data;
using Chatapp.Core.Helper.View;
using Chatapp.Core.Model;
using Chatapp.Core.Model.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Chatapp.Server.Model {
  public class Server {
    public Admin Admin { get; private set; }
    public Socket Socket { get; private set; }
    public State.Server State { get; private set; }
    public List<Client> Clients { get; private set; }

    public Server() {
      this.Admin = null;
      this.Socket = null;
      this.State = Model.State.Server.Stopped;
      this.Clients = new List<Client>();
    }

    public bool Authenticate(string username, string password) {
      using (var database = new ChatappEntities()) {
        var admin = database.Admins.Where(a => a.Username == username).FirstOrDefault();
        if (admin == null) {
          return false;
        }

        if (!BCrypt.Net.BCrypt.Verify(password, admin.Password)) {
          return false;
        }

        this.Admin = admin;
        this.State = Model.State.Server.Ready;
        return true;
      }
    }

    private void Listen() {
      try {
        while (this.State == Model.State.Server.Ready) {
          this.Socket.Listen(100);
          new Thread(() => this.Receive(new Client(this.Socket.Accept()))) { IsBackground = true }.Start();
        }
      } catch {
        this.State = Model.State.Server.Stopped;
        Alert.Error("An error occurred when listening to client");
      }
    }

    private void Receive(Client client) {
      try {
        while (this.State == Model.State.Server.Ready && client.State == Model.State.Client.Ready) {
          var data = new byte[5120];
          client.Socket.Receive(data);
          var message = Encode.Deserialize(data);
          this.Analyze(client, message);
        }
      } catch {
        this.Disconnect(client);
        Alert.Error("An error occurred when receiving from client");
      }
    }

    private void Send(Client client, Flag.Server flag, IData data) {
      try {
        if (this.State == Model.State.Server.Ready && client.State == Model.State.Client.Ready) {
          client.Socket.Send(Encode.Serialize(new Message(flag, data)));
        }
      } catch {
        this.Disconnect(client);
        Alert.Error("An error occurred when sending to client");
      }
    }

    private void Analyze(Client client, Message message) {
      switch (message.Flag) {
        case Flag.Client.AuthRequest:
          var authRequestData = (AuthRequestData)message.Data;
          if (client.Authenticate(authRequestData.Username, authRequestData.Password)) {
            var authResponseData = new AuthResponseData(true);
            this.Clients.ForEach(c => {
              authResponseData.Users.Add(c.User);
              this.Send(c, Flag.Server.UserJoin, new JoinData(client.User));
            });

            this.Send(client, Flag.Server.AuthResponse, authResponseData);
            this.Clients.Add(client);
            //BllServer.Instance.Main.AddClient(client);
          } else {
            this.Send(client, Flag.Server.AuthResponse, new AuthResponseData(false));
          }
          break;

        case Flag.Client.Disconnect:
          this.Disconnect(client);
          break;

        case Flag.Client.SendText:
          var sendTextData = (SendTextData)message.Data;
          var toClient = this.Clients.Where(c => c.User == sendTextData.User).FirstOrDefault();
          if (toClient == null) {
            this.Send(client, Flag.Server.SendResponse, new SendResponseData(false));
            break;
          }

          this.Send(toClient, Flag.Server.SendText, new SendTextData(client.User, sendTextData.Text));
          break;
      }
    }

    private void Disconnect(Client client) {
      if (client.State == Model.State.Client.Connecting) {
        this.Clients.Remove(client);
        //BllServer.Instance.Main.RemoveClient(client);
        //DalAccount.Instance.Logout(client.Account.Name);
        this.Clients.ForEach(c => this.Send(c, Flag.Server.UserLeave, new LeaveData(client.User)));
      }

      client.Disconnect();
    }

    public void Start() {
      this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
      this.Socket.Bind(new IPEndPoint(IPAddress.Any, Config.Port));
      new Thread(this.Listen) { IsBackground = true }.Start();
    }

    public void Stop() {
      if (this.Admin != null) {
        //DalAccount.Instance.Logout(Account.Name);
      }

      if (this.Socket != null) {
        this.Clients.ForEach(c => this.Disconnect(c));
        this.State = Model.State.Server.Stopped;
        this.Socket.Close();
        this.Socket.Dispose();
      }
    }
  }
}
