using System.Xml.Serialization;

namespace PrivatBankApiWrapper.ResponseDto.RestIndividual
{
    [XmlType(AnonymousType = true)]
    public class TransactionDto
    {
        /// <remarks />
        [XmlAttribute("card")]
        public string Card { get; set; }

        /// <remarks />
        [XmlAttribute("appcode")]
        public string AppCode { get; set; }

        /// <remarks />
        [XmlAttribute("trandate")]
        public string TransactionDate { get; set; }

        /// <remarks />
        [XmlAttribute("amount")]
        public string Amount { get; set; }

        /// <remarks />
        [XmlAttribute("cardamount")]
        public string CardAmount { get; set; }

        /// <remarks />
        [XmlAttribute("rest")]
        public string Rest { get; set; }

        /// <remarks />
        [XmlAttribute("terminal")]
        public string Terminal { get; set; }

        /// <remarks />
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}