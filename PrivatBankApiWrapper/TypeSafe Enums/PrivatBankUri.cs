namespace PrivatBankApiWrapper.TypeSafe_Enums
{
    internal class PrivatBankUri
    {
        public static PrivatBankUri Balance = new PrivatBankUri("https://api.privatbank.ua/p24api/balance");
        public static PrivatBankUri RestIndividual = new PrivatBankUri("https://api.privatbank.ua/p24api/rest_fiz");
        public static PrivatBankUri RestLegal = new PrivatBankUri("https://api.privatbank.ua/p24api/rest_yur");

        private PrivatBankUri(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}