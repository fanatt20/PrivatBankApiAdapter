namespace PrivatBankApiWrapper.DataProperties
{
    internal class Wait : IDataProperty
    {
        internal int WaitTime { get; set; }

        public string GetXml()
        {
            return "<wait>" + WaitTime + "</wait>";
        }
    }
}