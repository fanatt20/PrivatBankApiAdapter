namespace ApiPrivatBankAdapter
{
    public class Merchant
    {
        internal Merchant(string id, string password)
        {
            Id = id;
            Password = password;
        }

        public string Id { get; private set; }
        public string Password { get; private set; }
    }
}