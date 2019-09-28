using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            this.productId = productId;
        }

        public int productId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice.Equals(0)) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;
    }
}
