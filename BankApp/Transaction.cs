using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Transaction
    {
        public readonly int AccountNumber;
        public readonly TransactionType Type;
        public readonly decimal Sum;
        public readonly string Details;

        public Transaction(int accountNumber, TransactionType type, decimal sum, string details)
        {
            AccountNumber = accountNumber;
            Type = type;
            Sum = sum;
            Details = details;
        }
    }
}
