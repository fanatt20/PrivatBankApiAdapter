using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    [XmlType(AnonymousType = true)]
    public class BalanceDataDto
    {
        /// <remarks />
        [XmlElement("oper",Form = XmlSchemaForm.Unqualified)]
        public string Operation { get; set; }

        /// <remarks />
        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("cardbalance", typeof (CardBalanceDto), Form = XmlSchemaForm.Unqualified,
            IsNullable = false)]
        public CardBalanceDto[] info { get; set; }
    }
}