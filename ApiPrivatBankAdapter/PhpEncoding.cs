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
            List<int> resultAsInts = new List<int>();

            resultAsInts.AddRange(str.Select(Convert.ToInt32));
            
            if (resultAsInts.All(num => num < 128))
                return Encoding.ASCII.GetBytes(str.ToCharArray());
            return Encoding.UTF8.GetBytes(str.ToCharArray());
            
        }
    }
}
