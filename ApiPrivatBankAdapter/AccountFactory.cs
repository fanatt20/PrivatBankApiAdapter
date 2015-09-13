using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter
{
    public static class AccountFactory
    {
        public static Account CreateAccount(string name, string password)
        {

            var passwordInMd5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray("password"));
            /*
             * In api, password transmitted as sha1(md5($data.$password)) but md5() return string,
             * for this reason we need to cast the result of md5() to string as byte array and then use sha1()
             */
            var passwordInMd5AsString = BitConverter.ToString(passwordInMd5).Replace("-", string.Empty).ToLower();
            var passwordInSha1AndMd5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray(passwordInMd5AsString));
            return new Account(name, BitConverter.ToString(passwordInSha1AndMd5).Replace("-",string.Empty).ToLower());
        }
    }
}
