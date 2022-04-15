using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public System.Int32 UserId { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String FakNum { get; set; }
        public Int32 Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public User(String _username, String _password, String _faknum, Int32 _role)
        {
            Username = _username;
            Password = _password;
            FakNum = _faknum;
            Role = _role;

        }

        public User(string username, string password, string fakNum, int role, DateTime created) : this(username, password, fakNum, role)
        {
            Created = created;
        }


        public User() { }
    }
}
