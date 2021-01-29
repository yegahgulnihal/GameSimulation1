using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
