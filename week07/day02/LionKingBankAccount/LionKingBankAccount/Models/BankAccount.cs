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
        private string currency;

        public BankAccount(string name, float balance, string animalType, string currency)
        {
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
            this.currency = currency;
        }

        public string Name { get => name; set => name = value; }
        public float Balance { get => balance; set => balance = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public string Currency { get => currency; }

        public string FormatCurrency()
        {
            return Balance.ToString("N2");
        }
    }
}
