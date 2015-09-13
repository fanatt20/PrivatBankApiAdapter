using System;
using System.Linq;
using System.Text;

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