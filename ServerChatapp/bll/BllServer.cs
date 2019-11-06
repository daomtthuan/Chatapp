using ServerChatapp.dal;
using ServerChatapp.dto;

namespace ServerChatapp.bll
{
    public class BllServer
    {
        private static BllServer instance;
        private Server server;

        private BllServer()
        {
            Server = new Server();
        }

        public static BllServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BllServer();
                }
                return instance;
            }

            private set => instance = value;
        }

        public Server Server { get => server; private set => server = value; }

        public void Login(string name, string password)
        {
            if (DalAccount.Instance.Login(name, password, 1))
            {
                Server.Start(new Account(name));
            }
        }
    }
}
