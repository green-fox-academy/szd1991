using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccount.Models
{
    public class BankAccount
    {
        private int id = 1;
        private static int idCounter;
        private string name;
        private float balance;
        private string animalType;
        private string currency;

        public BankAccount(string name, float balance, string animalType)
        {
            id = idCounter++;
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
            currency = "¢himp฿one";
        }

        public string Name { get => name; set => name = value; }
        public float Balance { get => balance; set => balance = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public string Currency { get => currency; }
        public int ID { get => id; }

        public string FormatBalance()
        {
            return Balance.ToString("N2");
        }
    }
}
