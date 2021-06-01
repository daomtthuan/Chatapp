using Chatapp.ChatappCore.DataHelpers;
using Chatapp.ChatappCore.DataHelpers.Data;
using Chatapp.ChatappCore.ViewHelpers;
using Chatapp.ChatappServer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Chatapp.ChatappServer.App {
  class Server {
    private static Server _instance;
    private static readonly object _lock = new();
    private readonly ChatappEntities _entities;

    public int Id { get; private set; }
    public int InformationId { get; private set; }
    public string Username { get; private set; }
    public Socket Socket { get; private set; }
    public ServerState State { get; private set; }
    public List<Client> Clients { get; private set; }

    private Server() {
      _entities = new ChatappEntities();
      Id = 0;
      InformationId = 0;
      Username = null;
      Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
      State = ServerState.Stopped;
      Clients = new List<Client>();
    }

    private void Listen() {
      try {
        while (State == ServerState.Starting) {
          Socket.Listen(100);
          new Thread(() => Receive(new Client(Socket.Accept()))) { IsBackground = true }.Start();
        }
      } catch {
        State = ServerState.Stopped;
        Alert.Error("An error occurred when listening to client");
      }
    }

    private void Receive(Client client) {
      try {
        while (State == ServerState.Starting && client.State == ClientState.Connecting) {
          var data = new byte[5120];
          client.Socket.Receive(data);
          var message = MessageEncode.Deserialize(data);
          Analyze(client, message);
        }
      } catch {
        Disconnect(client);
        Alert.Error("An error occurred when receiving from client: " + client);
      }
    }

    private void Send(Client client, MessageFlag flag, IData data) {
      try {
        if (State == ServerState.Starting && client.State == ClientState.Connecting) {
          client.Socket.Send(MessageEncode.Serialize(new Message(flag, data)));
        }
      } catch {
        client.Logout();
        Alert.Error("An error occurred when sending to client: " + client);
      }
    }

    private void Analyze(Client client, Message message) {
      switch (message.Flag) {
        case MessageFlag.ClientRequestLogin: {
            var data = (RequestLoginData)message.Data;
            if (!client.Login(data.Username, data.Password)) {
              Send(client, MessageFlag.ServerResponseLogin, new ResponseLoginData(false, client.Username, _entities.Information.Find(InformationId).FullName));
            }
          }
          break;
      }
    }

    private void Disconnect(Client client) {
      if (client.State == ClientState.Connecting) {
        Clients.Remove(client);
        //BllServer.Instance.Main.RemoveClient(client);
        //DalAccount.Instance.Logout(client.Account.Name);
        Clients.ForEach(c => Send(c, MessageFlag.ServerDisconnect, new DisconnectData(client.Username)));
      }
      client.Logout();
    }

    public void Start() {
      try {
        Socket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(ConfigurationManager.AppSettings["Port"])));
        new Thread(Listen) { IsBackground = true }.Start();
        State = ServerState.Starting;
      } catch (Exception) {
        State = ServerState.Stopped;
        Alert.Error("An error occurred when starting server");
      }
    }

    public void Stop() {
      if (Socket != null) {
        Clients.ForEach(c => Disconnect(c));
        Socket.Close();
      }
      State = ServerState.Stopped;
      Clients.Clear();
    }

    public bool Login(string username, string password) {
      var account = _entities.Admins.Where(a => a.Username == username).FirstOrDefault();
      if (account == null) {
        return false;
      }
      if (!BCrypt.Net.BCrypt.Verify(password, account.Password)) {
        return false;
      }
      Id = account.Id;
      InformationId = account.InformationId;
      Username = account.Username;
      return true;
    }

    public void Logout() {
      Id = 0;
      InformationId = 0;
      Username = null;
    }

    public static Server Instance {
      get {
        if (_instance == null) {
          lock (_lock) {
            if (_instance == null) {
              _instance = new Server();
            }
          }
        }
        return _instance;
      }
    }
  }
}
