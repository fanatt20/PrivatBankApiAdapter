using System;
using System.IO;
using System.Xml;
using PrivatBankApiWrapper.ResponseDto;

namespace PrivatBankApiWrapper.Parser
{
    internal class XmlMapper
    {
        public static BalanceDto MapBalance(string data)
        {
            var card = new ResponseDto.Card();
            var splitedData = RegExpCollection.ClosingTag.Replace(data, "{*EndTag*}").Split('\n');
            var reader = new XmlTextReader(new StringReader(data));


            throw new NotImplementedException();
        }
    }
}