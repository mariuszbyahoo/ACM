using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AdressRepository
    {
        /// <summary>
        /// Retrieve one adress
        /// </summary>
        /// <param name="adressId"></param>
        /// <returns></returns>
        public Adress Retrieve(int adressId)
        {
            // Create the instance of the Adress class
            // Pass in the requested Id
            var adress = new Adress(adressId);

            //Code that retrieves the defined adress

            // Temporary hard coded values to return 
            // a populated adress
            if(adressId == 1)
            {
                adress.adressType = AdressType.Home;
                adress.StreetLine1 = "Bag End";
                adress.StreetLine2 = "Bagshot row";
                adress.City = "Hobbiton";
                adress.StateOrProvince = "Shire";
                adress.Country = "Middle Earth";
                adress.PostalCode = "144";
            }
            return adress;
        }

        public IEnumerable<Adress> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined adresses 
            // for the customer.

            // Temporary hard-coded values to return
            // a set of adresses for a customer
            var adressList = new List<Adress>();
            Adress adress = new Adress(1)
            {
                adressType = AdressType.Home,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            adressList.Add(adress);

            adress = new Adress(2)
            {
                adressType = AdressType.Work,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            adressList.Add(adress);

            return adressList;
        }

        public bool Save(Adress adress)
        {
            var success = true;

            if (adress.HasChanges)
            {
                if (adress.IsValid)
                {
                    if (adress.IsNew)
                    {
                        // Call an Instert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
