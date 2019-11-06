using System.Net.Sockets;

namespace ServerChatapp.dto
{
    public class Client
    {
        private Account account;
        private Socket socket;

        public Client(Socket socket)
        {
            Socket = socket;
        }

        public Account Account { get => account; set => account = value; }
        public Socket Socket { get => socket; private set => socket = value; }
        public string Address { get => socket.RemoteEndPoint.ToString(); }

        public void Close()
        {
            Socket.Close();
        }

        public override string ToString()
        {
            return Address + ((Account != null) ? (" - " + Account) : "");
        }
    }
}