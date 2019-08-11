using System;
using System.Collections.Generic;

namespace Server.Objects
{
    public class Administrator
    {
        private String name;
        private String password;

        public Administrator(string name, string password)
        {
            this.name = name.ToLower();
            this.password = password;
        }

        public static bool Login(string name, string password)
        {
            List<Administrator> administrators = new List<Administrator>();
            administrators.Add(new Administrator("Admin", "1"));
            administrators.Add(new Administrator("Daomtthuan", "1809"));
            foreach(Administrator administrator in administrators)
                if (name.ToLower() == administrator.name && password == administrator.password) return true;
            return false;
        }
    }
}
