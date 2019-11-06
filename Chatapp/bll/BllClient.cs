using Chatapp.dto;

namespace Chatapp.bll
{
    public class BllClient
    {
        private static BllClient instance;
        private Client client;

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

        public Client Client { get => client; private set => client = value; }

        public void Login(string name, string password)
        {
           
        }
    }
}
