using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                CurrentPrice = 5.5m,
                Description = "Desc",
                ProductName = "Sunflowers"
            };

            // -- Act
            var actual = productRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18m,
                Description = "Description",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Description",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.AreEqual(false, actual);

        }
    }
}
