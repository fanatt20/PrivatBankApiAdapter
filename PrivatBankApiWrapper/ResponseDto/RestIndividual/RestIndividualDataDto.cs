using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.RestIndividual
{
    [XmlType(AnonymousType = true)]
    public class RestIndividualDataDto
    {
        /// <remarks />
        [XmlElement("oper", Form = XmlSchemaForm.Unqualified)]
        public string Operation { get; set; }

        /// <remarks />
        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("statements", typeof (StatementsDto), Form = XmlSchemaForm.Unqualified,
            IsNullable = false)]
        public StatementsDto[] info { get; set; }
    }
}