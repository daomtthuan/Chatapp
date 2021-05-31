using Data;

namespace ServerChatapp.dal
{
    public class DalAccount
    {
        private static DalAccount instance;

        private DalAccount() { }

        public static DalAccount Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DalAccount();
                }
                return instance;
            }

            private set => instance = value;
        }

        public bool Login(string name, string password, int role)
        {
            object data = DataProvider.Instance.ExecuteScalar("exec [Login] @name , @password , @role", new object[] { name, Encode.HasPassword(password), role });
            return (int)data == 1;
        }

        public void Logout(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("exec [Logout] @loginName", new object[] { name });
        }
    }
}