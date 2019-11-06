using System.Net.Sockets;

namespace ServerChatapp.dto
{
    public class Client
    {
        private Account account;
        private Socket socket;
        private bool connect;

        public Client(Socket socket)
        {
            Socket = socket;
            Connect = true;
        }

        public Account Account { get => account; set => account = value; }
        public Socket Socket { get => socket; private set => socket = value; }
        public bool Connect { get => connect; private set => connect = value; }

        public void Close()
        {            
            Connect = false;
            if (Socket != null)
            {
                Socket.Close();
                Socket.Dispose();
            }
        }

        public override string ToString()
        {
            return socket.RemoteEndPoint.ToString() + ((Account != null) ? (" - " + Account) : "");
        }
    }
}