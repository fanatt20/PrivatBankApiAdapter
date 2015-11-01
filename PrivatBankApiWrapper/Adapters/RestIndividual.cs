using System.Collections.Generic;

namespace PrivatBankApiWrapper.ResponseDto
{
    public class RestIndividual
    {
        //TODO:status
        public decimal Credit { get; set; }
        public decimal Debet { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}