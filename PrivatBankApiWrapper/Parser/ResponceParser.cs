using PrivatBankApiWrapper.DomainObjects;
using PrivatBankApiWrapper.Encoding;
using PrivatBankApiWrapper.Exceptions;

namespace PrivatBankApiWrapper.Parser
{
    internal static class ResponceParser
    {
        internal static Balance GetBalance(string balanceInXml, string password)
        {
            if (!SignatureIsCorrect(balanceInXml, password))
                throw new SignaturesDoNotMatchException();

            return XmlMapper.MapBalance(balanceInXml);
        }

        internal static RestIndividual GetRestIndividual(string balanceInXml, string password)
        {
            if(!SignatureIsCorrect(balanceInXml,password))
                throw new SignaturesDoNotMatchException();
            return XmlMapper.MapRestIndividual(balanceInXml);
        }

        private static bool SignatureIsCorrect(string balanceResponce, string password)
        {
            var signatureFromServer =
                RegExpCollection.Numbers.Match(RegExpCollection.Signature.Match(balanceResponce).Value).Value;
            var data = RegExpCollection.Data.Match(balanceResponce).Value.Replace("<data>", "").Replace("</data>", "");
            var signatureFromDocument = Cryptography.GetEncrypt(data + password);

            return signatureFromServer.Equals(signatureFromDocument);
        }
    }
}