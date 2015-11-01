using System.Collections.Generic;
using System.Text;
using PrivatBankApiWrapper.Encoding;
using PrivatBankApiWrapper.Request.DataProperties;

namespace PrivatBankApiWrapper.Request
{
    internal class Request
    {
        public Request()
        {
            DataProperties = new List<IDataProperty>();
        }

        internal int MerchantId { get; set; }
        internal List<IDataProperty> DataProperties { get; set; }

        internal string GetXml(string password, int waitTime = 50, string operation = "cmt", bool isTest = false)
        {
            DataProperties.Add(new Operation {Value = operation});
            DataProperties.Add(new Test {IsTest = isTest});
            DataProperties.Add(new Wait {WaitTime = waitTime});

            var result = new StringBuilder();
            result.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>").Append("<request version=\"1.0\">");
            var data = new StringBuilder();
            DataProperties.ForEach(property => data.Append(property.GetXml()));
            var signature = Cryptography.GetEncrypt(data + password);
            result.Append("<merchant>")
                .Append("<id>" + MerchantId + "</id>")
                .Append("<signature>" + signature + "</signature>")
                .Append("</merchant>")
                .Append("<data>").Append(data).Append("</data>")
                .Append("</request>");

            return result.ToString();
        }
    }
}