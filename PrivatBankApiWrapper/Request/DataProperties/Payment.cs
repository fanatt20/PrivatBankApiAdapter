using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrivatBankApiWrapper.Request.DataProperties
{
    internal class Payment : IDataProperty
    {
        public Payment()
        {
            AttributesDictionary = new Dictionary<string, string>();
        }

        internal int? Id { get; set; }

        internal Dictionary<string, string> AttributesDictionary { get; }

        public string GetXml()
        {
            return "<payment id=\"" + (Id != null ? Id.ToString() : "") + "\">" +
                   AttributesDictionary.Aggregate(new StringBuilder(),
                       (builder, pair) =>
                           builder.Append("<prop name=\"" + pair.Key + "\" value=\"" + pair.Value + "\" />"),
                       builder => builder.ToString()) + "</payment>";
            ;
        }
    }
}