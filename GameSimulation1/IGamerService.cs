using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation1
{
    interface IGamerService
    {
        void Add(Gamer gamer);

        void Delete(Gamer gamer);

        void Update(Gamer gamer);
       

    }
}
