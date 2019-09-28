using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            this.productId = productId;
        }

        public int productId { get; set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;
    }
}
