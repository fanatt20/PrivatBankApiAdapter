using System.Collections.Generic;
using System.Linq;

namespace ApiPrivatBankAdapter.DataProperties
{
    internal class Payment : IDataProperty
    {
        internal int? Id { get; set; }
        public Payment()
        {
            AttributesDictionary = new Dictionary<string, string>();
        }

        internal Dictionary<string, string> AttributesDictionary { get; private set; }

        public string GetXml()
        {
            return "<payment id=\"" + (Id != null ? Id.ToString() : "") + "\">" + AttributesDictionary.Aggregate(string.Empty,
                (key, value) => "<prop name=\"" + key + "\" value=\"" + value + "\" />") + "</payment>";
        }
    }
}