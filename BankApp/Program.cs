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


            Account petrovAccount = new Account(petrov, 300100);
            petrovAccount.AddMoney(50000, "пополнение счета");
            petrovAccount.WithrawMoney(15000, "снятие части");

           List<Transaction> petrovTrans = petrovAccount.GetTransactionHistory();


            //User segeeva = new User("Sergeev", 28, Gender.Male);
            Account sergeevaAccount = new Account(new User("Sergeeva", 28, Gender.Female), 1001);
            sergeevaAccount.AddMoney(15000, "пополнение депозита");
            sergeevaAccount.WithrawMoney(5000, "снятие средств");
            List<Transaction> sergeevaTrans = sergeevaAccount.GetTransactionHistory();







            Bank sberbank = new Bank("Сбербанк");

            sberbank.AddAccount(petrovAccount);
            sberbank.AddAccount(sergeevaAccount);

            sberbank.AddMoney(1001, 7777, "addInPart");

            //sberbank.AddAccount();
            sberbank.PrintAccounts();
            Console.WriteLine();
            sberbank.PrintTransactionLog(300100);
            sberbank.PrintTransactionLog(1001);




            Console.ReadKey();

        }
    }
}
