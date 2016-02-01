using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Global
{
    [XmlType(AnonymousType = true)]
    public class Merchant
    {
        /// <remarks />
        [XmlElement("id", Form = XmlSchemaForm.Unqualified)]
        public string Id { get; set; }

        /// <remarks />
        [XmlElement("signature", Form = XmlSchemaForm.Unqualified)]
        public string Signature { get; set; }
    }
}