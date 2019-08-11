using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Objects
{
    public class User
    {
        #region Instance variables
        private string name;            // Name Account
        private string password;        // Password Account
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor User account
        /// </summary>
        /// <param name="name">Name account</param>
        /// <param name="password">Password account</param>
        public User(string name, string password)
        {
            this.name = name.ToLower();
            this.password = password;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Check Account to login. Return true if login successful, otherwise return false 
        /// </summary>
        /// <param name="name">Name account</param>
        /// <param name="password">Password account</param>
        /// <returns>Return true if login successful, otherwise return false </returns>
        public static bool Login(string name, string password)
        {
            List<User> users = new List<User>();
            users.Add(new User("Daomtthuan", "1809"));
            users.Add(new User("User1", "1"));
            users.Add(new User("User2", "2"));
            users.Add(new User("User3", "3"));
            foreach (User user in users)
                if (name.ToLower() == user.name && password == user.password) return true;
            return false;
        }
        #endregion
    }
}
