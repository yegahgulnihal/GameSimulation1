using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    class OrderManager : IOrderService
    {
        
        public void AddOrder(Orders order)
        {
            Console.WriteLine("New Order Added!");
        }

        public void DeleteOrder(Orders order)
        {
            Console.WriteLine("Order Deleted!");
        }

        public void UpdateOrder(Orders order)
        {
            Console.WriteLine("Order Updated!");
        }
    }
}
