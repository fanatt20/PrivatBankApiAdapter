using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter
{
    public static class PhpEncoding
    {
        public static byte[] GetByteArray(string str)
        {
            if (str.Select(Convert.ToInt32).All(num => num < 128))
                return Encoding.ASCII.GetBytes(str.ToCharArray());
            return Encoding.UTF8.GetBytes(str.ToCharArray());
            
        }
    }
}
