using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Adress
    {
        public Adress()
        {

        }
        public Adress(int adressId)
        {
            AdressId = adressId;
        }
        public int AdressId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince {get; set;}
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public AdressType adressType { get; set; }


        /// <summary>
        /// Validates the adress data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (PostalCode == null)
                return false;
            else
                return true;
        }
    }
}
