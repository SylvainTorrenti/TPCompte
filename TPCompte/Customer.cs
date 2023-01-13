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
        /// <summary>
        /// Constructor customer with all attribute
        /// </summary>
        /// <param name="cIN"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="phone"></param>
        public Customer(string cIN, string firstname, string lastname, string phone)
        {
            _CIN = cIN;
            _firstName = firstname;
            _lastName = lastname;
            _phone = phone;
        }
        /// <summary>
        /// Constructor customer with CIN, Firstname and Lastname
        /// </summary>
        /// <param name="cIN"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        public Customer(string cIN, string firstname, string lastname)
        {
            CIN = cIN;
            Firstname = firstname;
            Lastname = lastname;
        }
        #endregion
        #region Get & Set CIN
        /// <summary>
        /// CIN
        /// </summary>
        public string CIN { get => _CIN; set => _CIN = value; }
        #endregion
        #region Get & Set FirstName
        /// <summary>
        /// First Name
        /// </summary>
        public string Firstname { get => _firstName; set => _firstName = value; }
        #endregion
        #region Get & Set LastName
        /// <summary>
        /// Last Name
        /// </summary>
        public string Lastname { get => _lastName; set => _lastName = value; }
        #endregion
        #region Get & Set Phone
        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }
        #endregion
        #region Method
        /// <summary>
        /// Display Customer
        /// </summary>
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
