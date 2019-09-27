using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order, sets the OrderDate property to DateTimeOffset.Now
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Customer class
            // pass in requested id
            var order = new Order(1);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated order
            if (orderId == 1)
            {
                order.PurchasePrice = 5.5m;
                order.OrderDate = new DateTime(DateTime.Now.Year, 4, 14, 10, 00, 00);
            }
            return order;
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
