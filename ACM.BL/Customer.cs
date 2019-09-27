using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Separation of Responsibilities: Building the Address Class
 */
namespace ACM.BL
{
    public class Customer
    {
        // After instantiating a first constructor with any parameter, 
        // we need to write a code for a default constructor if we want him to appear at a runtime.
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        // Shortened version of property below, called Auto-Generated property.
        private string _lastName;

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
