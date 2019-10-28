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
            foreach (Account item in _accounts)
            {
                if (item.AccountNumber == accountNumber)
                {
                    item.WithrawMoney(sum, details);
                    break;
                }
            }

        }

        public void PrintTransactionLog(int accountNumber)
        {
            foreach (Account item in _accounts)
            {
                if (item.AccountNumber == accountNumber)
                {
                    string accountTitle = $"|| Номер счета: {item.AccountNumber} ||";
                    string lineIitle = new string('=', accountTitle.Length);
                    Console.WriteLine($"{lineIitle}\n{accountTitle}\n{lineIitle}");

                    string accountInfoTitle = $"| {"Операция",20} | {"Сумма",15} | {"Описание операции",40} |";
                    string line = new string('-', accountInfoTitle.Length);
                    Console.WriteLine($"{line}\n{accountInfoTitle}\n{line}");

                    foreach (Transaction trans in item.GetTransactionHistory())
                    {
                        string accountInfo = $"| {Utilits.GetTransactionTypeAsText(trans.Type),20} | {trans.Sum,15} | {trans.Details,40} |";
                        Console.WriteLine($"{accountInfo}\n{line}");
                    }
                }
            }
        }

        public void PrintAccounts()
        {

        }
    }
}
