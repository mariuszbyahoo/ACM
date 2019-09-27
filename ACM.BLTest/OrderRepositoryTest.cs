using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                PurchasePrice = 5.5m,
                OrderDate = new DateTime(DateTime.Now.Year, 4, 14, 10, 00, 00)
            };

            // -- Act
            var actual = orderRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.PurchasePrice, actual.PurchasePrice);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
