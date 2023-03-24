using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Login
    {
       public String Usuario { get; set; }
        public String Password { get; set; }

        public Login()
        {
        }

        public Login(string usuario, string password)
        {
            Usuario = usuario;
            Password = password;
        }
    }
}
