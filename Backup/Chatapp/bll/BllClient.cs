using Chatapp.dto;
using Chatapp.ui;

namespace Chatapp.bll
{
    public class BllClient
    {
        private static BllClient instance;
        private Client client;
        private Login login;
        private Main main;

        private BllClient()
        {
            Client = new Client();
        }

        public static BllClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BllClient();
                }
                return instance;
            }

            private set => instance = value;
        }

        public void Send(string name, string message)
        {
            Client.Send("chat|" + name + "|" + message);
        }

        public Client Client { get => client; private set => client = value; }
        public Login Login { get => login; set => login = value; }
        public Main Main { get => main; set => main = value; }
    }
}
