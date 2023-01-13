using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    internal class Customer
    {
        #region Attribute
        private string _CIN;
        private string _firstName;
        private string _lastName;
        private string _phone;
        #endregion
        #region Constructor
        public Customer(string cIN, string firstname, string lastname, string phone)
        {
            _CIN = cIN;
            _firstName = firstname;
            _lastName = lastname;
            _phone = phone;
        }
        public Customer(string cIN, string firstname, string lastname)
        {
            CIN = cIN;
            Firstname = firstname;
            Lastname = lastname;
        }
        #endregion
        #region Get & Set CIN
        public string CIN { get => _CIN; set => _CIN = value; }
        #endregion
        #region Get & Set FirstName
        public string Firstname { get => _firstName; set => _firstName = value; }
        #endregion
        #region Get & Set LastName
        public string Lastname { get => _lastName; set => _lastName = value; }
        #endregion
        #region Get & Set Phone
        public string Phone { get => _phone; set => _phone = value; }
        #endregion
        #region Method
        public void DisplayCustomer()
        {
            Console.WriteLine($"CIN : {CIN}");
            Console.WriteLine($"NOM : {Lastname}");
            Console.WriteLine($"Prénom : {Firstname}");
            Console.WriteLine($"Tél : {Phone}");
        } 
        #endregion
    }
}
