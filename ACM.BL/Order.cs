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
            InstanceCount++;
            OrderId = InstanceCount;
        }
        public static int InstanceCount { get; set; } 
        public int OrderId { get; set; }
        public DateTimeOffset OrderDate { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate.Equals(DateTimeOffset.MinValue)) isValid = false;
            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            // Code which will retrieve a specific order
            return new Order();
        }

        public bool Save()
        {
            //Code which will save an order to the db

            return true;
        }

        public IList<Order> RetrieveAll()
        {
            return new List<Order>();
        }
    }
}
