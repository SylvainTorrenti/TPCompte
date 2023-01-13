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
        /// <summary>
        /// Constructor with Owner
        /// </summary>
        /// <param name="owner"></param>
        public Account(Customer owner)
        {
            _NB++;
            Owner = owner;
        }
        #endregion
        #region Get & Set Balance
        /// <summary>
        /// Balance
        /// </summary>
        public int Balance { get => _balance; set => _balance = value; }
        #endregion
        #region Get & Set Owner
        /// <summary>
        /// Owner
        /// </summary>
        internal Customer Owner { get => _owner; set => _owner = value; }
        #endregion
        #region Get & Set AccountNb
        /// <summary>
        /// AccountNB
        /// </summary>
        public int AccountNb { get => _accountNb; set => _accountNb = value; }
        #endregion
        #region Method
        /// <summary>
        /// Display Account
        /// </summary>
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
        /// <summary>
        /// Credit with amount
        /// </summary>
        /// <param name="somme"></param>
        /// <returns></returns>
        public int Credit(int somme)
        {
            return Balance = Balance + somme;
        }
        /// <summary>
        /// Credit with amount from an account
        /// </summary>
        /// <param name="somme"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public int CreditAccount(int somme, Account account)
        {
            account.Balance = account.Balance - somme;
            return Balance = Balance + somme;
        }
        /// <summary>
        /// Withdraw with amount
        /// </summary>
        /// <param name="somme"></param>
        /// <returns></returns>
        public int Withdraw(int somme)
        {
            return Balance = Balance - somme;
        }
        /// <summary>
        /// Withdraw with amount to an account
        /// </summary>
        /// <param name="somme"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public int WithdrawAccount(int somme, Account account)
        {
            account.Balance = Balance + somme;
            return Balance = Balance - somme;
        }
        /// <summary>
        /// Display number of account
        /// </summary>
        /// <returns></returns>
        public static int DisplayAccountNB()
        {
            return _NB - 1;
        }
        #endregion
    }
}
