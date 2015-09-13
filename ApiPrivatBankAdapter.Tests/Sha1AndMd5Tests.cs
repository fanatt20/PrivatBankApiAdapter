using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiPrivatBankAdapter.Tests
{
    [TestClass]
    public class Sha1AndMd5Tests
    {
        [TestMethod]
        public void TestMd5_AsciiLetters()
        {
            var passwordInMD5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray("password"));
            Assert.AreEqual("5f4dcc3b5aa765d61d8327deb882cf99",BitConverter.ToString(passwordInMD5).Replace("-",string.Empty).ToLower());
        }
        [TestMethod]
        public void TestMd5_UTF8Letters()
        {
            var passwordInMD5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray("passwordы"));
            Assert.AreEqual("222add55c7f7f4942b256d4cb27fee29", BitConverter.ToString(passwordInMD5).Replace("-", string.Empty).ToLower());
        }
        [TestMethod]
        public void TestSha1_AsciiLetters()
        {
            var passwordInMD5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray("password"));
            Assert.AreEqual("5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8", BitConverter.ToString(passwordInMD5).Replace("-", string.Empty).ToLower());
        }
        [TestMethod]
        public void TestSha1_UTF8Letters()
        {
            var passwordInMD5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray("passwordы"));
            Assert.AreEqual("62d1f4e1cc70202e6e2a6fe202d1064d1d680ae1", BitConverter.ToString(passwordInMD5).Replace("-", string.Empty).ToLower());
        }

        [TestMethod]
        public void TestMd5Sha1_AsciiLetters()
        {
            var md5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray("password"));
            var md5AsString = BitConverter.ToString(md5).Replace("-", string.Empty).ToLower();
            var sha1Md5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray(md5AsString));

            Assert.AreEqual("55c3b5386c486feb662a0785f340938f518d547f",  BitConverter.ToString(sha1Md5).Replace("-", string.Empty).ToLower());
        }
        [TestMethod]
        public void TestMd5Sha1_UTF8Letters()
        {
            var md5 = MD5.Create().ComputeHash(PhpEncoding.GetByteArray("passwordы"));
            var md5AsString = BitConverter.ToString(md5).Replace("-", string.Empty).ToLower();
            var sha1Md5 = SHA1.Create().ComputeHash(PhpEncoding.GetByteArray(md5AsString));
            Assert.AreEqual("7de9edf976aafb43592ca00c6c718b63372bf0b7", BitConverter.ToString(sha1Md5).Replace("-", string.Empty).ToLower());
        }
    }
}
