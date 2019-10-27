using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class User
    {
        private string _fullName;
        private int _age;
        private Gender _gender;

        public User(string fullName, int age, Gender gender)
        {
            _fullName = fullName;
            _age = age;
            _gender = gender;
        }
    }
}
