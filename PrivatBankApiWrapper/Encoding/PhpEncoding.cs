using System;
using System.Linq;

namespace PrivatBankApiWrapper.Encoding
{
    public static class PhpEncoding
    {
        public static byte[] GetByteArray(string str)
        {
            if (str.Select(Convert.ToInt32).All(num => num < 128))
                return System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
            return System.Text.Encoding.UTF8.GetBytes(str.ToCharArray());
        }
    }
}