using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    [XmlType(AnonymousType = true)]
    public class DataForBalance
    {
        /// <remarks />
        [XmlElement("oper",Form = XmlSchemaForm.Unqualified)]
        public string Operation { get; set; }

        /// <remarks />
        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("cardbalance", typeof (CardBalance), Form = XmlSchemaForm.Unqualified,
            IsNullable = false)]
        public CardBalance[] info { get; set; }
    }
}