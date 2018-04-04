using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccount.Models
{
    public class BankAccount
    {
        // Name, Balance, AnimalType

        private string name;
        private float balance;
        private string animalType;

        public BankAccount(string name, float balance, string animalType)
        {
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
        }
    }
}
