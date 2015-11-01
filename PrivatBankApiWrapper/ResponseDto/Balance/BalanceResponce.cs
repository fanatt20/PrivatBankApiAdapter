using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    /// <remarks />
    [XmlType( AnonymousType = true)]
    [XmlRoot(Namespace = "",ElementName = "response", IsNullable = false)]
    public class BalanceResponce
    {
        /// <remarks />
        [XmlElement("merchant", Form = XmlSchemaForm.Unqualified)]
        public Merchant Merchant { get; set; }

        /// <remarks />
        [XmlElement("data", Form = XmlSchemaForm.Unqualified)]
        public DataForBalance Data { get; set; }

        /// <remarks />
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}