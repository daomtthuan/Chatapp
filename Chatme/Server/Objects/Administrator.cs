using System;
using System.Collections.Generic;

namespace Server.Objects
{
    public class Administrator
    {
        #region Instance variables
        private string name;
        private string password;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor Administrator account
        /// </summary>
        /// <param name="name">Name account</param>
        /// <param name="password">Password account</param>
        public Administrator(string name, string password)
        {
            this.name = name.ToLower();
            this.password = password;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Check Account to login. Return true if login successful, otherwise return false 
        /// </summary>
        /// <param name="name">Username of Account</param>
        /// <param name="password">Password of Account</param>
        /// <returns>Return true if login successful, otherwise return false </returns>
        public static bool Login(string name, string password)
        {
            List<Administrator> administrators = new List<Administrator>();
            administrators.Add(new Administrator("Admin", "1"));
            administrators.Add(new Administrator("Daomtthuan", "1809"));
            foreach(Administrator administrator in administrators)
                if (name.ToLower() == administrator.name && password == administrator.password) return true;
            return false;
        }
        #endregion
    }
}
