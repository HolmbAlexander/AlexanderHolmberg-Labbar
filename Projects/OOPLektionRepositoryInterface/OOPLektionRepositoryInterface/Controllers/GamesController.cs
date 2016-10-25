using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLektionRepositoryInterface.DataStores.Repositories;
using OOPLektionRepositoryInterface.Models;

namespace OOPLektionRepositoryInterface.Controllers
{
    class GamesController
    {
        private IRepositiry repository = new ListRepository();

        public void CreateGame()
        {
            var newGame = UI.CreatGame();
            repository.AddGame(newGame);
        }

        public void PrintGamesList()
        {
            UI.PrintGameList(repository.GetGames());
            Console.ReadKey(true);
        }

        public void RemoveGame()
        {
            var games = repository.GetGames();
            var index = UI.SelectGame(repository.GetGames()) - 1;
            repository.RemoveGame(games[index]);
        }

        public void EditGame()
        {
            var games = repository.GetGames();
            UI.PrintGameList(games);
            int index = UI.SelectGame(games) - 1;

            UI.EditGames(games[index]);
        }
    }
}
