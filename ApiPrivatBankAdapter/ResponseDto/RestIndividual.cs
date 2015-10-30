using System.Collections.Generic;

namespace ApiPrivatBankAdapter.ResponseDto
{
    public class RestIndividual
    {
        //TODO:status
        public decimal Credit { get; set; }
        public decimal Debet { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}