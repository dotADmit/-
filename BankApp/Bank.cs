using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Bank
    {
        public readonly string Name;
        private List<Account> _accounts;

        public Bank(string name)
        {
            Name = name;
            _accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void AddMoney(int accountNumber, decimal sum, string details)
        {
            foreach (Account item in _accounts)
            {
                if (item.AccountNumber == accountNumber)
                {
                    item.AddMoney(sum, details);
                    break;
                }
            }
        }

        public void WithrawMoney(int accountNumber, decimal sum, string details)
        {

        }

        public void PrintTransactionLog(int accountNumber)
        {

        }

        public void PrintAccounts()
        {

        }
    }
}
