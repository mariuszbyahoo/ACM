using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // After instantiating a first constructor with any parameter, 
        // we need to write a code for a default constructor if we want him to appear at a runtime.
        public Customer() : this(0) 
        {
        // Adding a colon and referencing a custom constructor from below is called "Constructor Chaining". 
        // Use it any time one constructor needs to call another. In this case, the default constructor calls
        // the custom one, providing a default customerId value of 0. Now the Adress List is always initialized.
        // Regardless of the way Customer is initialized.
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AdressList =  new List<Adress>();
        }

        public static int InstanceCount { get; set; }
        public List<Adress> AdressList { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public int Type { get; set; }
        private string _lastName;

        // Shortened version of property below, called Auto-Generated property.
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;
        }
    }
}
