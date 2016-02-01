using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using PrivatBankApiWrapper.DomainObjects;
using PrivatBankApiWrapper.Parser;
using PrivatBankApiWrapper.Request;
using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.PrivatBankConnectionManager
{
    internal class PrivatBankManager
    {
        public Balance GetBalance(int merchantId, int cardNumber, string password, string country)
        {
            var request = WebRequest.CreateHttp(PrivatBankUri.Balance.Value);
            using (var sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(RequestFactory.GetBalance(merchantId, password, cardNumber, country));
            }

            var responseStream = request.GetResponse().GetResponseStream();

            if (responseStream == null)
                throw new IOException();

            using (var sr = new StreamReader(responseStream))
            {
                return ResponceParser.GetBalance(sr.ReadToEnd(), password);
            }
        }

        public RestIndividual GetRestIndividual(int merchantId, string password, int cardNum, DateTime from, DateTime to)
        {
            var request = WebRequest.Create(PrivatBankUri.RestIndividual.Value);
            using (var sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(RequestFactory.GetRestAsIndividual(merchantId, password, cardNum, from, to));
            }
            var responseStream = request.GetResponse().GetResponseStream();
            if (responseStream == null)
                throw new IOException();

            using (var sr = new StreamReader(responseStream))
            {
                return ResponceParser.GetRestIndividual(sr.ReadToEnd(), password);
            }
        }
    }
}