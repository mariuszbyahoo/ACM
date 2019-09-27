using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public Adress shippingAdress { get; set; }
        public static int InstanceCount { get; set; } 
        public int OrderId { get; set; }

        public decimal? PurchasePrice { get; set; }
        public DateTime OrderDate { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate.Equals(DateTime.MinValue)) isValid = false;
            if (PurchasePrice == 0) isValid = false;
            return isValid;
        }
    }
}
