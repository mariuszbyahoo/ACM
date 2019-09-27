using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidValidation()
        {
            // -- Arrange
            var order = new Order()
            {
                PurchasePrice = 5.5m,
                OrderDate = new DateTime(DateTime.Now.Year, 4, 14, 10, 00, 00)
            };

            var expected = true;

            // -- Act
            var actual = order.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidValidation()
        {
            // -- Arrange
            var order = new Order()
            {
                PurchasePrice = 0,
                OrderDate = DateTime.MinValue

            };

            var expected = false; 
            // We're assuming that an user had not defined any value to this member, so the validation will be false

            // -- Act
            var actual = order.Validate(); 

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
