using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAdress()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AdressList = new List<Adress>()
                {
                    new Adress()
                    {
                        adressType = AdressType.Home,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        StateOrProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Adress()
                    {
                        adressType = AdressType.Work,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        StateOrProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AdressList[i].adressType, actual.AdressList[i].adressType);
                Assert.AreEqual(expected.AdressList[i].StreetLine1, actual.AdressList[i].StreetLine1);
                Assert.AreEqual(expected.AdressList[i].City, actual.AdressList[i].City);
                Assert.AreEqual(expected.AdressList[i].Country, actual.AdressList[i].Country);
                Assert.AreEqual(expected.AdressList[i].PostalCode, actual.AdressList[i].PostalCode);
            }
        }
    }
}
