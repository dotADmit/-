using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User petrov = new User("Petrov", 35, Gender.Male);

            Bank sberbank = new Bank("Сбер");

            Account ivanov = new Account(petrov, 300100);
            ivanov.AddMoney(50000, "пополнение счета");
            ivanov.WithrawMoney(15000, "снятие части");

           List<Transaction> lkjlj = ivanov.GetTransactionHistory();

            sberbank.AddAccount(ivanov);


            //sberbank.AddAccount();



            sberbank.PrintAccounts();

            sberbank.PrintTransactionLog(12345678);
        }
    }
}
