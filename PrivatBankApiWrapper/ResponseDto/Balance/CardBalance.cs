using System.Xml.Schema;
using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.Balance
{
    [XmlType(AnonymousType = true)]
    public class CardBalance
    {
        /// <remarks />
        [XmlElement("av_balance",Form = XmlSchemaForm.Unqualified)]
        public decimal AvBalance { get; set; }

        /// <remarks />
        [XmlElement("bal_date",Form = XmlSchemaForm.Unqualified)]
        public string BalDate { get; set; }

        /// <remarks />
        [XmlElement("bal_dyn",Form = XmlSchemaForm.Unqualified)]
        public string BalDyn { get; set; }

        /// <remarks />
        [XmlElement("balance",Form = XmlSchemaForm.Unqualified)]
        public decimal Balance { get; set; }

        /// <remarks />
        [XmlElement("fin_limit", Form = XmlSchemaForm.Unqualified)]
        public decimal FinLimit { get; set; }

        /// <remarks />
        [XmlElement("trade_limit",Form = XmlSchemaForm.Unqualified)]
        public decimal TradeLimit { get; set; }

        /// <remarks />
        [XmlElement("card", Form = XmlSchemaForm.Unqualified)]
        public Card Card { get; set; }
    }
}