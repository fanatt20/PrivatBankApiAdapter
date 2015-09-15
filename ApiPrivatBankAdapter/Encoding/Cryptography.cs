using System;
using System.Security.Cryptography;

namespace ApiPrivatBankAdapter.Encoding
{
    internal static class Cryptography
    {
        internal static string GetEncrypt(string str)
        {
            var strInMd5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray(str));
            /*
             * In api, password transmitted as sha1(md5($data.$password)) but md5() return string,
             * for this reason we need to cast the result of md5() to string as byte array and then use sha1()
             */
            var strInMd5AsString = BitConverter.ToString(strInMd5).Replace("-", string.Empty).ToLower();
            var strInSha1AndMd5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray(strInMd5AsString));
            return BitConverter.ToString(strInSha1AndMd5).Replace("-", string.Empty).ToLower();
        }
    }
}