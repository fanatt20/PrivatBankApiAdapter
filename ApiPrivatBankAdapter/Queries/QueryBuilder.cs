using System;
using ApiPrivatBankAdapter.DataProperties;

namespace ApiPrivatBankAdapter.Queries
{
    public class QueryBuilder
    {
        private readonly int _merchantId;
        private readonly string _password;

        public QueryBuilder(int merchantId, string password)
        {
            _merchantId = merchantId;
            _password = password;
        }

        public string GetBalanceQuery(int cardNumber, string country)
        {
            var query = new Query { MerchantId = _merchantId };
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("cardnum", cardNumber.ToString());
            paymentProp.AttributesDictionary.Add("country", country);
            query.DataProperties.Add(paymentProp);
            return query.GetXml(_password);
        }

        public string GetRestAsIndividual(int cardNum, DateTime from, DateTime to)
        {
            var query = new Query { MerchantId = _merchantId };
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("sd", from.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("ed", to.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("card", cardNum.ToString());
            query.DataProperties.Add(paymentProp);

            return query.GetXml(_password);
        }

        public string GetRestAsLegalPerson(int year, int month)
        {
            var query = new Query { MerchantId = _merchantId };
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("year", year.ToString());
            paymentProp.AttributesDictionary.Add("month", month.ToString("dd.mm.yyyy"));
            query.DataProperties.Add(paymentProp);

            return query.GetXml(_password);
        }
    }
}