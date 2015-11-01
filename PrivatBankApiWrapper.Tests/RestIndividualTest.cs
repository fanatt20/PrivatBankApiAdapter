using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrivatBankApiWrapper.ResponseDto.RestIndividual;
using PrivatBankApiWrapper.Tests.Properties;

namespace PrivatBankApiWrapper.Tests
{
    [TestClass]
    public class RestIndividualTestr
    {
        private RestIndividualResponse _response;

        [TestInitialize]
        public void ParseAndAssignRestIndividual()
        {
            var serializer = new XmlSerializer(typeof(RestIndividualResponse));
            using (TextReader reader = new StringReader(Resources.RestIndividual))
            {
                _response = (RestIndividualResponse)serializer.Deserialize(reader);
            }
        }
        [TestMethod]
        public void TestRestIndividualResponce_MerchantField()
        {
            Assert.AreEqual("75482", _response.Merchant.Id);
            Assert.AreEqual("553995c5ccc8c81815b58cf6374f68f00a28bbd7", _response.Merchant.Signature);
        }

        [TestMethod]
        public void TestRestIndividualResponce_DataField()
        {
            Assert.AreEqual("cmt", _response.Data.Operation);
        }

        [TestMethod]
        public void TestRestIndividual_StatementsAttributes()
        {
            Assert.AreEqual("excellent",_response.Data.info[0].Status);
            Assert.AreEqual((decimal)0.0, _response.Data.info[0].Credit);
            Assert.AreEqual((decimal)0.3, _response.Data.info[0].Debet);
        }

        [TestMethod]
        public void TestRestIndividual_StatementsField()
        {
            Statement[] stats = _response.Data.info[0].Statements;

            Assert.AreEqual(3, stats.Length);

            Assert.AreEqual("5168742060221193",stats[0].Card);
            Assert.AreEqual("591969",stats[0].AppCode);
            Assert.AreEqual("2013-09-02",stats[0].TransactionDate);
            Assert.AreEqual("0.10 UAH",stats[0].Amount);
            Assert.AreEqual("-0.10 UAH",stats[0].CardAmount);
            Assert.AreEqual("0.95 UAH",stats[0].Rest);
            Assert.AreEqual("Пополнение мобильного +380139917053 через «Приват24»",stats[0].Terminal);
            Assert.AreEqual("",stats[0].Description);
            


        }
    }
}
