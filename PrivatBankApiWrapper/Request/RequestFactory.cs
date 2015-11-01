using System;
using PrivatBankApiWrapper.DataProperties;

namespace PrivatBankApiWrapper.Request
{
    public class RequestFactory
    {
        private readonly int _merchantId;
        private readonly string _password;

        public RequestFactory(int merchantId, string password)
        {
            _merchantId = merchantId;
            _password = password;
        }

        public string GetBalance(int cardNumber, string country)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = _merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("cardnum", cardNumber.ToString());
            paymentProp.AttributesDictionary.Add("country", country);
            request.DataProperties.Add(paymentProp);
            return request.GetXml(_password);
        }

        public string GetRestAsIndividual(int cardNum, DateTime from, DateTime to)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = _merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("sd", from.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("ed", to.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("card", cardNum.ToString());
            request.DataProperties.Add(paymentProp);

            return request.GetXml(_password);
        }

        public string GetRestAsLegalPerson(int year, int month)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = _merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("year", year.ToString());
            paymentProp.AttributesDictionary.Add("month", month.ToString("dd.mm.yyyy"));
            request.DataProperties.Add(paymentProp);

            return request.GetXml(_password);
        }
    }
}