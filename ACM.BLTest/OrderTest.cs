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
                OrderDate = DateTime.Today
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
            var order = new Order();

            var expected = false; 
            // We're assuming that an user had not defined any value to this member, so the validation will be false

            // -- Act
            var actual = order.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidNumeration()
        {
            // -- Arrange
            Order.InstanceCount = 0; // static field needs to be reset to 0 before the test

            var order = new Order();

            var expected = 1;

            // -- Act

            // -- Assert
            Assert.AreEqual(expected, Order.InstanceCount);
        }
    }
}
