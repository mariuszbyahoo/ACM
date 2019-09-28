using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAdressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public static int InstanceCount { get; set; } 
        public int OrderId { get; set; }

        public decimal? PurchasePrice { get; set; }
        public DateTime OrderDate { get; set; }

        public override bool Validate()
        {
            bool isValid = true;
            if (OrderDate.Equals(DateTime.MinValue)) isValid = false;
            if (PurchasePrice == 0) isValid = false;
            return isValid;
        }

        public override string ToString() => $"{OrderDate.Date} ({OrderId})";
    }
}
