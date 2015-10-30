namespace PrivatBankApiWrapper.TypeSafe_Enums
{
   public  class Currency
    {
        public string Value { get; protected set; }
        internal Currency(string currency)
        {
            Value = currency;
        }
    }
}
