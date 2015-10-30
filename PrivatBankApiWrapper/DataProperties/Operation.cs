namespace PrivatBankApiWrapper.DataProperties
{
    internal class Operation : IDataProperty
    {
        internal string Value { get; set; }

        public string GetXml()
        {
            return "<oper>" + Value + "</oper>";
        }
    }
}