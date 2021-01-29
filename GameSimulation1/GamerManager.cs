using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{       //Micro Service
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)//Gamer manager'a bağımlılığı var Soyut yapı
        {
            this.userValidationService = userValidationService;
        }

       
        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer Added!");
            }
            else
            {
                Console.WriteLine("Failed at Adding!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer Deleted!");
            }
            else
            {
                Console.WriteLine("Failed at Deleting!");
            }
        }

        public void Update(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer Updated!");
            }
            else
            {
                Console.WriteLine("Failed at Updating!");
            }
        }
    }
}
