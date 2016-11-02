using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.DataStores.Repositories;

namespace Labb5.Controllers
{
    class GamesController
    {
        private IRepository repositoryGames = new ListRepositories();

        public void CreateGame()
        {
            var newGame = UI.CreateGame();
            repositoryGames.AddGame(newGame);
        }

        public void PrintGameList()
        {
            UI.PrintGameList(repositoryGames.GetGames());
            Console.ReadKey(true);
        }

        public void RemoveGame()
        {
            var games = repositoryGames.GetGames();
            var index = UI.SelectGame(repositoryGames.GetGames()) - 1;
            repositoryGames.RemoveGame(games[index]);
        }

        public void EditGame()
        {
            var games = repositoryGames.GetGames();
            UI.PrintGameList(games);
            int index = UI.SelectGame(games) - 1;

            UI.EditGame(games[index]);
        }
    }
}
