using System.Xml.Schema;
using System.Xml.Serialization;
using PrivatBankApiWrapper.ResponseDto.Global;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    /// <remarks />
    [XmlType( AnonymousType = true)]
    [XmlRoot(Namespace = "",ElementName = "response", IsNullable = false)]
    public class BalanceDto
    {
        /// <remarks />
        [XmlElement("merchant", Form = XmlSchemaForm.Unqualified)]
        public Merchant Merchant { get; set; }

        /// <remarks />
        [XmlElement("data", Form = XmlSchemaForm.Unqualified)]
        public BalanceDataDto BalanceDataDto { get; set; }

        /// <remarks />
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}