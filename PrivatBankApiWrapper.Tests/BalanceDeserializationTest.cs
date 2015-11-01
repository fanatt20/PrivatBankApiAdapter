using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrivatBankApiWrapper.ResponseDto.Balance;
using PrivatBankApiWrapper.Tests.Properties;

namespace PrivatBankApiWrapper.Tests
{
    [TestClass]
    public class BalanceDeserializationTest
    {
        private BalanceResponce _balance;

        [TestInitialize]
        public void ParseAndAssignBalance()
        {
            var serializer = new XmlSerializer(typeof (BalanceResponce));
            using (TextReader reader = new StringReader(Resources.Balance))
            {
                _balance = (BalanceResponce) serializer.Deserialize(reader);
            }
        }

        [TestMethod]
        public void MerchantTest()
        {
            Assert.AreEqual("75482", _balance.Merchant.Id);
            Assert.AreEqual("bff932d0e97877619965283ed0d147c87a78b6c1", _balance.Merchant.Signature);
        }

        [TestMethod]
        public void DataTest()
        {
            Assert.AreEqual("cmt", _balance.Data.Operation);
        }

        [TestMethod]
        public void CardTest()
        {
            var card = _balance.Data.info[0].Card;
            Assert.AreEqual("5168742060221193", card.Account);
            Assert.AreEqual("5168742060221193", card.CardNumber);
            Assert.AreEqual("Карта для Выплат Gold", card.AccName);
            Assert.AreEqual("CC", card.AccType);
            Assert.AreEqual("UAH", card.Currency);
            Assert.AreEqual("Карта для Выплат Gold", card.CardType);
            Assert.AreEqual("5168742060221193", card.MainCardNumber);
            Assert.AreEqual("NORM", card.CardStat);
            Assert.AreEqual("M", card.Src);
        }

        [TestMethod]
        public void CardBalance()
        {
            var cardBalance = _balance.Data.info[0];
            Assert.AreEqual((decimal)0.95, cardBalance.AvBalance);
            Assert.AreEqual("11.09.13 15:56", cardBalance.BalDate);
            Assert.AreEqual("E", cardBalance.BalDyn);
            Assert.AreEqual((decimal)0.00, cardBalance.FinLimit);
            Assert.AreEqual((decimal)0.00, cardBalance.TradeLimit);
        }
    }
}