using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiPrivatBankAdapter.Tests
{
    [TestClass]
    public class MerchantFactoryTests
    {
        [TestMethod]
        public void TestCreate()
        {
            var account = MerchantFactory.CreateAccount("John", "password");
           Assert.AreEqual("John",account.Id);
           Assert.AreEqual("55c3b5386c486feb662a0785f340938f518d547f",account.Password);
        }
    }
}
