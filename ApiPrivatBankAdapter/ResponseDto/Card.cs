using ApiPrivatBankAdapter.TypeSafe_Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter.ResponseDto
{
   public class Card
    {
        public string Account { get;internal set; }
        public string CardNumber { get;internal set; }
        public string CardType { get; internal set; }
        public string CardName { get;internal set; }
        public Currency Currency { get;internal set; }
       //TODO:Get all posible stats
       //TODO:src
        public Status Status { get; internal set; }
        public string MainCardNumber { get; internal set; }

    }
}
