using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.RestIndividual
{
    [XmlType(AnonymousType = true)]
    public class StatementsDto
    {
        /// <remarks />
        [XmlElement("statement", Form = XmlSchemaForm.Unqualified)]
        public TransactionDto[] Statements { get; set; }

        /// <remarks />
        [XmlAttribute("status")]
        public string Status { get; set; }

        /// <remarks />
        [XmlAttribute("credit")]
        public decimal Credit { get; set; }

        /// <remarks />
        [XmlAttribute("debet")]
        public decimal Debet { get; set; }
    }
}