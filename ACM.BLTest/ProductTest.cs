using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var p = new Product()
            {
                ProductName = "new one",
                CurrentPrice = 10.50m
            };

            var expected = true;

            // -- Act
            var actual = p.Validate();

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePriceNotSpecified()
        {
            // -- Arrange
            var p = new Product()
            {
                ProductName = "new one"
            };

            var expected = false;

            // -- Act
            var actual = p.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNameNotSpecified()
        {
            // -- Arrange 
            var p = new Product()
            {
                CurrentPrice = 0.99m
            };

            var expected = false;

            // -- Act
            var actual = p.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNothingSpecified()
        {
            // -- Arrange 
            var p = new Product();

            var expected = false;

            // -- Act
            var actual = p.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
