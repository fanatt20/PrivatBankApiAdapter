using System;

namespace PrivatBankApiWrapper.ResponseDto
{
    internal class BalanceDto
    {
        public Card Card { get; set; }
        public decimal AvaibleBalance { get; set; }
        public DateTime BalanceTime { get; set; }
        public decimal Value { get; set; }
        public decimal CreditLimit { get; set; }
    }
}