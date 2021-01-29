using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate== 1997 && gamer.FirstName=="Yegah" 
                && gamer.LastName=="Değirmenci")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
