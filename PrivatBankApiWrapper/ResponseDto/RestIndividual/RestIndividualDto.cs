using System.Xml.Schema;
using System.Xml.Serialization;
using PrivatBankApiWrapper.ResponseDto.Balance;

namespace PrivatBankApiWrapper.ResponseDto.RestIndividual
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", ElementName = "response", IsNullable = false)]
    public class RestIndividualResponse
    {
        /// <remarks />
        [XmlElement("merchant", Form = XmlSchemaForm.Unqualified)]
        public Merchant Merchant { get; set; }

        /// <remarks />
        [XmlElement("data", Form = XmlSchemaForm.Unqualified)]
        public RestIndividualDataDto Data { get; set; }

        /// <remarks />
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}