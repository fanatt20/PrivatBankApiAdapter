using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter.ResponseDto
{
    class Balance
    {
        //TODO:bal_dyn
        public Card Card { get; set; }
        public decimal AvaibleBalance { get; set; }
        public DateTime BalanceTime { get; set; }
        public Decimal Value { get; set; }
        public Decimal CreditLimit { get; set; }
    }
}
