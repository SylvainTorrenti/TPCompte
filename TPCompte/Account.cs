using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    internal class Account
    {
        #region Attribute
        private static int _NB = 1;
        private int _accountNb = _NB;
        private int _balance;
        private Customer? _owner;
        #endregion
        #region Constructor
        public Account(Customer owner)
        {
            _NB++;
            Owner = owner;
        }
        #endregion
        #region Get & Set Balance
        public int Balance { get => _balance; set => _balance = value; }
        #endregion
        #region Get & Set Owner
        internal Customer Owner { get => _owner; set => _owner = value; }
        #endregion
        #region Get & Set AccountNb
        public int AccountNb { get => _accountNb; set => _accountNb = value; } 
        #endregion
        #region Method
        public void DisplayAccount()
        {
            Console.WriteLine($"Numéro de Compte : {AccountNb}");
            Console.WriteLine($"Solde de compte : {Balance}");
            Console.WriteLine($"Propriétaire du compte :");
            Console.WriteLine($"CIN : {Owner.CIN}");
            Console.WriteLine($"NOM : {Owner.Lastname}");
            Console.WriteLine($"Prénom : {Owner.Firstname}");
            Console.WriteLine($"Tél : {Owner.Phone}");
            Console.WriteLine();
        }
        public int Credit(int somme)
        {
            return Balance = Balance + somme;
        }
        public int CreditAccount(int somme, Account account)
        {
            account.Balance = account.Balance - somme;
            return Balance = Balance + somme;
        }
        public int Withdraw(int somme)
        {
            return Balance = Balance - somme;
        }
        public int WithdrawAccount(int somme, Account account)
        {
            account.Balance = Balance + somme;
            return Balance = Balance - somme;
        }
        public int DisplayAccountNB()
        {
            return _NB;
        }
        #endregion
    }
}
