using System;

namespace BankAccount.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
