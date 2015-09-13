using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter
{
    public class Account
    {
        public string Id { get; private set; }
        public string Password { get; private set; }

        internal Account(string id, string password)
        {
            Id = id;
            Password = password;

        }
        
    }
}
