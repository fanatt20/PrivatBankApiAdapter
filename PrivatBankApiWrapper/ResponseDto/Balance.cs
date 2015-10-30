using System;

namespace PrivatBankApiWrapper.ResponseDto
{
    internal class Balance
    {
        //TODO:bal_dyn
        public Card Card { get; set; }
        public decimal AvaibleBalance { get; set; }
        public DateTime BalanceTime { get; set; }
        public decimal Value { get; set; }
        public decimal CreditLimit { get; set; }
    }
}