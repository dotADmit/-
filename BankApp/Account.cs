using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        public readonly User _user;
        public readonly int AccountNumber;
        private decimal _balance;
        private List<Transaction> _transactionLog;

        public Account(User user, int accountNumber)
        {
            _transactionLog = new List<Transaction>();
            _user = user;
            AccountNumber = accountNumber;
        }

        public void AddMoney(decimal sum, string details)
        {
            _balance += sum;
            _transactionLog.Add(new Transaction(AccountNumber, TransactionType.Add, sum, details));
        }

        public void WithrawMoney(decimal sum, string details)
        {
            _balance -= sum;
            _transactionLog.Add(new Transaction(AccountNumber, TransactionType.Withraw, sum, details));
        }

        public List<Transaction> GetTransactionHistory()
        {
            List<Transaction> newTransactionLog = new List<Transaction>();

            foreach (Transaction item in _transactionLog)
            {
                newTransactionLog.Add(item);
            }

            return newTransactionLog;
        }
    }
}
