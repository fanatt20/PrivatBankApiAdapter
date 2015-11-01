using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    [XmlType(AnonymousType = true)]
    public class Card
    {
        /// <remarks />
        [XmlElement("account", Form = XmlSchemaForm.Unqualified)]
        public string Account { get; set; }

        /// <remarks />
        [XmlElement("card_number", Form = XmlSchemaForm.Unqualified)]
        public string CardNumber { get; set; }

        /// <remarks />
        [XmlElement("acc_name", Form = XmlSchemaForm.Unqualified)]
        public string AccName { get; set; }

        /// <remarks />
        [XmlElement("acc_type", Form = XmlSchemaForm.Unqualified)]
        public string AccType { get; set; }

        /// <remarks />
        [XmlElement("currency", Form = XmlSchemaForm.Unqualified)]
        public string Currency { get; set; }

        /// <remarks />
        [XmlElement("card_type", Form = XmlSchemaForm.Unqualified)]
        public string CardType { get; set; }

        /// <remarks />
        [XmlElement("main_card_number", Form = XmlSchemaForm.Unqualified)]
        public string MainCardNumber { get; set; }

        /// <remarks />
        [XmlElement("card_stat", Form = XmlSchemaForm.Unqualified)]
        public string CardStat { get; set; }

        /// <remarks />
        [XmlElement("src", Form = XmlSchemaForm.Unqualified)]
        public string Src { get; set; }
    }
}