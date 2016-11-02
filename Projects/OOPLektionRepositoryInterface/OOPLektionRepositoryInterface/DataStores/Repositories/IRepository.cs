using OOPLektionRepositoryInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLektionRepositoryInterface.DataStores.Repositories
{
   interface IRepositiry
    {
        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);
    }
}
