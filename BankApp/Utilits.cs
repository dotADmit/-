using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Utilits
    {
        public static string GetTransactionTypeAsText(TransactionType type)
        {
            if (type == TransactionType.Add)
                return "Пополнение средств";
            if (type == TransactionType.Withraw)
                return "Снятие средств";
            return "";
        }
    }
}
