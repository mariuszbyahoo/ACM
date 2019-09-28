using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for OrderItemTest
    /// </summary>
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var o = new OrderItem()
            {
                product = new Product()
                {
                    CurrentPrice = 5.5m,
                    Description = "Desc",
                    ProductId = 001,
                    ProductName = "New one"
                },
                orderItemId = 001,
                PurchasePrice = 5.0,
                Quantity = 5
            };

            var expected = true;

            // -- Act
            var actual = o.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNullProduct()
        {
            // -- Arrange
            var o = new OrderItem()
            {
                product = null,
                orderItemId = 001,
                PurchasePrice = 5.0,
                Quantity = 5
            };

            var expected = false;

            // -- Act
            var actual = o.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNullPurchasePrice()
        {
            // -- Arrange
            var o = new OrderItem()
            {
                product = new Product()
                {
                    CurrentPrice = 5.5m,
                    Description = "Desc",
                    ProductId = 001,
                    ProductName = "New one"
                },
                orderItemId = 001,
                Quantity = 5
            };

            var expected = false;

            // -- Act
            var actual = o.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNullQuantity()
        {
            // -- Arrange
            var o = new OrderItem()
            {
                product = new Product()
                {
                    CurrentPrice = 5.5m,
                    Description = "Desc",
                    ProductId = 001,
                    ProductName = "New one"
                },
                orderItemId = 001,
                PurchasePrice = 5.0
            };

            var expected = false;

            // -- Act
            var actual = o.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
