using System;
using ApiPrivatBankAdapter.TypeSafe_Enums;

namespace ApiPrivatBankAdapter.ResponseDto
{
    public class Money
    {
        public Currency Currency { get; set; }
        public Decimal Value { get; set; }
    }
}