using System;
using PrivatBankApiWrapper.Request.DataProperties;

namespace PrivatBankApiWrapper.Request
{
    public static class RequestFactory
    {
        public static string GetBalance(int merchantId, string password,int cardNumber, string country)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("cardnum", cardNumber.ToString());
            paymentProp.AttributesDictionary.Add("country", country);
            request.DataProperties.Add(paymentProp);
            return request.GetXml(password);
        }

        public static string GetRestAsIndividual(int merchantId, string password, int cardNum, DateTime from, DateTime to)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("sd", from.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("ed", to.ToString("dd.mm.yyyy"));
            paymentProp.AttributesDictionary.Add("card", cardNum.ToString());
            request.DataProperties.Add(paymentProp);

            return request.GetXml(password);
        }

        public static string GetRestAsLegalPerson(int merchantId, string password,int year, int month)
        {
            var request = new PrivatBankApiWrapper.Request.Request {MerchantId = merchantId};
            var paymentProp = new Payment();
            paymentProp.AttributesDictionary.Add("year", year.ToString());
            paymentProp.AttributesDictionary.Add("month", month.ToString("dd.mm.yyyy"));
            request.DataProperties.Add(paymentProp);

            return request.GetXml(password);
        }
    }
}