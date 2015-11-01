using System.Collections.Generic;
using PrivatBankApiWrapper.ResponseDto;

namespace PrivatBankApiWrapper.DomainObjects
{
    public class RestIndividual
    {
        public decimal Credit { get; set; }
        public decimal Debet { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}