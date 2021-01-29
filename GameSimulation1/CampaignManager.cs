using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    class CampaignManager:ICampaignManager
    {
        IOrderService orderService1;
        public CampaignManager(IOrderService orderService)
        {
            this.orderService1 = orderService;
        }

       

    }
}
