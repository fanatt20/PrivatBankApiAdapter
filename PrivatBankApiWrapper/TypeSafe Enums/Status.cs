namespace PrivatBankApiWrapper.TypeSafe_Enums
{
    public class Status
    {
        internal Status(string status)
        {
            Value = status;
        }

        public string Value { get; protected set; }
    }
}