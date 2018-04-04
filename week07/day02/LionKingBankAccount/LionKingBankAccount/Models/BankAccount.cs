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
        private int balance;
        private string animalType;

        public BankAccount(string name, int balance, string animalType)
        {
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
        }

        public string Name { get => name; set => name = value; }
        public int Balance { get => balance; set => balance = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
    }
}
