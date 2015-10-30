using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ApiPrivatBankAdapter.ResponseDto;

namespace ApiPrivatBankAdapter
{
    static class ResponceParser
    {
        static internal Balance GetBalance(string responceInXml)
        {
            //TODO:Exception handling
            var result = new Balance();
            
            
            if (SignatureIsCorrect(responceInXml))
            {
                
                


            }

            return result;

        }

        private static bool SignatureIsCorrect(string balanceResponce)
        {
            throw new NotImplementedException();
        }
    }
}
