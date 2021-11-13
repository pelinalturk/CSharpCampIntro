using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulator
{
    interface GameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Sale(Gamer gamer, Game game, Campaing campaing);
    }
}
