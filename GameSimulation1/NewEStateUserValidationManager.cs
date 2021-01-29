using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
