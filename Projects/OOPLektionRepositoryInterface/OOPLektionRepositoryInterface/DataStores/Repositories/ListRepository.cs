using OOPLektionRepositoryInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLektionRepositoryInterface.DataStores.Repositories
{
    class ListRepository : IRepositiry
    { 
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }
    }
}
