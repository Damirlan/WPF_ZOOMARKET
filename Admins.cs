using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    internal class Admins
    {
        private int id { get; set; }
        private string login, password, email;

        public Admins() { }

        public Admins(string login, string email, string password)
        {
            this.login = login;
            this.email = email;
            this.password = password;
        }
    }
}
