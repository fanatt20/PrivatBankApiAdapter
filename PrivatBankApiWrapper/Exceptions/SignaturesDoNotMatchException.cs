using System;

namespace PrivatBankApiWrapper.Exceptions
{
    internal class SignaturesDoNotMatchException : ArgumentException
    {
        public SignaturesDoNotMatchException()
        {
        }

        public SignaturesDoNotMatchException(string message) : base(message)
        {
        }
    }
}