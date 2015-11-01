using System;
using System.IO;
using System.Net;
using PrivatBankApiWrapper.DomainObjects;
using PrivatBankApiWrapper.Parser;
using PrivatBankApiWrapper.Request;
using PrivatBankApiWrapper.ResponseDto;
using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.PrivatBankConnectionManager
{
    internal class PrivatBankManager
    {
        public Balance GetBalance(int merchantId, int cardNumber, string password, string country)
        {
            Balance result;
            var request = WebRequest.CreateHttp(PrivatBankUri.Balance.Value);
            using (var sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(new RequestFactory(merchantId, password).GetBalance(cardNumber, country));
            }

            var response = request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                result = ResponceParser.GetBalance(sr.ReadToEnd(),password);
            }
            return result;

        }
    }
}