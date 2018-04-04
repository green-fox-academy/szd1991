using LionKingBankAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccount.ViewModels
{
    public class BankAccounts
    {
        public List<BankAccount> Accounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Lion"),
            new BankAccount("Scar", 1200.58f, "Lion"),
            new BankAccount("Rafiki", 10256.98f, "Mandrill"),
            new BankAccount("Ed", 0, "Hyena"),
            new BankAccount("Pumbaa", 502, "Warthog"),
            new BankAccount("Timon", 52, "Meerkat"),
            new BankAccount("Zazu", 25688, "Hornbill")
        };
    }
}
