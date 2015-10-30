using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.ResponseDto
{
    public class Money
    {
        public Currency Currency { get; set; }
        public decimal Value { get; set; }
    }
}