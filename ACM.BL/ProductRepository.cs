using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Customer class
            // pass in requested id
            var product = new Product(1);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (productId == 1)
            {
                product.CurrentPrice = 5.5m;
                product.Description = "Desc";
                product.ProductName = "Product";
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
