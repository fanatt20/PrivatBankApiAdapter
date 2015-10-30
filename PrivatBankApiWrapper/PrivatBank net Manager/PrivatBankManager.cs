using System;
using System.IO;
using System.Net;
using PrivatBankApiWrapper.Queries;
using PrivatBankApiWrapper.ResponseDto;
using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.PrivatBank_net_Manager
{
    internal class PrivatBankManager
    {
        public Balance GetBalance(int merchantId, int cardNumber, string password, string country)
        {
            var result = new Balance();
            var request = WebRequest.CreateHttp(PrivatBankUri.Balance.Value);
            using (var sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(new QueryFactory(merchantId, password).GetBalance(cardNumber, country));
            }

            var response = request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                //todo parse response
                throw new NotImplementedException();
            }

            return result;
        }
    }
}