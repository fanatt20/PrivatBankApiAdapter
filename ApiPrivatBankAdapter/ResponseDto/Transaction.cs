using System;

namespace ApiPrivatBankAdapter.ResponseDto
{
    public class Transaction
    {
        public string Card { get; set; }
        //TODO:appcode
        public DateTime Date { get; set; }
        public Money Amount { get; set; }
        public Money CardAmount { get; set; }
        public Money CardRest { get; set; }
        public string Terminal { get; set; }
        public string Details { get; set; }
    }
}