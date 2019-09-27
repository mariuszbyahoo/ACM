using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public int orderItemId { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (product == null) isValid = false;
            if (Quantity == 0) isValid = false;
            if (PurchasePrice == 0) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            // Code retrieving a specified OrderItem
            return new OrderItem();
        }

        public bool Save()
        {
            //Code saving an OrderItem
            return true;
        }

    }
}
