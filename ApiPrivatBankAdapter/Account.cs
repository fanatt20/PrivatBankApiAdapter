using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter
{
    public class Account
    {
        public string Name { get; private set; }
        public string Password { get; private set; }

        internal Account(string name, string password)
        {
            Name = name;
            Password = password;

        }
        
    }
}
