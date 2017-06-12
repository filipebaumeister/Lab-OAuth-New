using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.webservice
{
    public class UserInfo : StatusRetorno
    {
        public int id;
        public string user;
        public string cpf;
        public string password;
        public string birthday;
        public string email;
        public int semester;
        public double valor;
        public int idCarro;
    }
}