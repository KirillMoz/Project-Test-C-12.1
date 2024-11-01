using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12._1._5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string Login, string Name, bool IsPremium) 
        {
            this.Login = Login;
            this.Name = Name;
            this.IsPremium = IsPremium;
        }
    }
}
