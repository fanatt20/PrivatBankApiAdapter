using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrivatBankAdapter.TypeSafe_Enums
{
    public class Status
    {
        public string Value { get;protected set; }

        internal Status( string status)
        {
            Value = status;

        }
    }
}
