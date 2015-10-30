using System.Text.RegularExpressions;

namespace PrivatBankApiWrapper
{
    public class RegExpCollection
    {
        public static readonly Regex Numbers = new Regex(@"\d+");
        public static readonly Regex Signature = new Regex(@"<signature>\d+</signature>");
        public static readonly Regex Data = new Regex(@"<data>\w+</data>");
        public static readonly Regex Tag = new Regex(@"<\w+>");
        public static readonly Regex ClosingTag = new Regex(@"</\w+>");
    }
}