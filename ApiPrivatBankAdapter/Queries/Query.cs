using System.Collections.Generic;
using System.Text;
using ApiPrivatBankAdapter.DataProperties;
using ApiPrivatBankAdapter.Encoding;

namespace ApiPrivatBankAdapter.Queries
{
    internal class Query
    {
        public Query()
        {
            DataProperties = new List<IDataProperty>();
        }

        internal int MerchantId { get; set; }
        internal List<IDataProperty> DataProperties { get; set; }

        internal string GetXml(string password)
        {
            var result = new StringBuilder();
            result.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            result.Append("<request version=\"1.0\">");
            var data = new StringBuilder();
            DataProperties.ForEach(property => data.Append(property.GetXml()));
            var signature = Cryptography.GetEncrypt(data + password);
            result.Append("<merchant>");
            result.Append("<id>" + MerchantId + "</id>");
            result.Append("<signature>" + signature + "</signature>");
            result.Append("</merchant>");
            result.Append("<data>");
            result.Append(data);
            result.Append("</data>");
            result.Append("</request>");
            return result.ToString();
        }
    }
}