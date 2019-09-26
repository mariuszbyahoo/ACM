using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Building Entity Classes: 
 * Using Snippets
 */
namespace ACM.BL
{
    public class Customer
    {
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
                return LastName + " " + FirstName;
            }
        }
    }
}
