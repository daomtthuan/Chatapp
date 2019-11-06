using System.Security.Cryptography;
using System.Text;

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

        private string HasPassword(string password)
        {
            string hasPass = "";
            foreach (byte item in new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(password)))
            {
                hasPass += item;
            }
            return hasPass;
        }

        public bool Login(string name, string password, int role)
        {
            object data = DataProvider.Instance.ExecuteScalar("exec [Login] @name , @password , @role", new object[] { name, HasPassword(password), role });
            return (int)data == 1;
        }

        public void Logout(string name, int role)
        {
            DataProvider.Instance.ExecuteNonQuery("[Logout] @loginName , @role", new object[] { name, role });
        }
    }
}