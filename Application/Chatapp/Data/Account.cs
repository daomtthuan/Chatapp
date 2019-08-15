using System.Security.Cryptography;
using System.Text;

namespace Data
{
    /// <summary>
    /// Account login
    /// </summary>
    public class Account
    {
        #region Properties
        /// <summary>
        /// Instance variable
        /// </summary>
        private static Account instance;
        #endregion

        #region Constructors
        /// <summary>
        /// Account Constructor
        /// </summary>
        private Account() { }
        #endregion

        #region Methods
        /// <summary>
        /// Has Password
        /// </summary>
        /// <param name="password">Password Account</param>
        /// <returns></returns>
        private string HasPassword(string password)
        {
            string hasPass = "";
            foreach (byte item in new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(password))) hasPass += item;
            return hasPass;
        }

        /// <summary>
        /// Login account return <paramref name="name"/>, otherwise return null
        /// </summary>
        /// <param name="name">Name Account</param>
        /// <param name="password">Password Account</param>
        /// <param name="role">Role Account</param>
        /// <returns>Name Account</returns>
        public string Login(string name, string password, int role)
        {
            object data = Provider.Instance.ExecuteScalar("[Login] @name , @password , @role", new object[] { name, HasPassword(password), role });
            return ((int)data == 1) ? name : null;
        }

        /// <summary>
        /// Logout account
        /// </summary>
        /// <param name="name">Name Account</param>
        /// <param name="role">Role Account</param>
        public void Logout(string name, int role)
        {
            Provider.Instance.ExecuteNonQuery("[Logout] @loginName , @role", new object[] { name, role });
        }
        #endregion

        #region Getter Setter
        /// <summary>
        /// Get Instance variable
        /// </summary>
        public static Account Instance { get => instance ?? new Account(); private set => instance = value; }
        #endregion
    }
}
