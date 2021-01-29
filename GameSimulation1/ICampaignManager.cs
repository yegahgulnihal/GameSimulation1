using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    interface ICampaignManager
    {
        void AddCampaign(Orders order)
        {
            Console.WriteLine("Campaign Updated!");
        }
        void DeleteCampaing(Orders order)
        {
            Console.WriteLine("Campaign Deleted!");
        }
        void UpdateCampaign(Orders order)
        {
            Console.WriteLine("Campaign Updated! ");
        }
    }
}
