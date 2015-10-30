using System;
using System.IO;
using System.Xml;
using PrivatBankApiWrapper.ResponseDto;

namespace PrivatBankApiWrapper.PrivatBank_net_Manager.Parser
{
    internal class XmlMapper
    {
        public static Balance MapBalance(string data)
        {
            var card = new Card();
            var splitedData = RegExpCollection.ClosingTag.Replace(data, "{*EndTag*}").Split('\n');
            var reader = new XmlTextReader(new StringReader(data));


            throw new NotImplementedException();
        }
    }
}