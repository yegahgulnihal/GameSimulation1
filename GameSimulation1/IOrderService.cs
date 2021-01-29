using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    interface IOrderService
    {
        void AddOrder(Orders order);
        void DeleteOrder(Orders order);
        void UpdateOrder(Orders order);
    }
}
