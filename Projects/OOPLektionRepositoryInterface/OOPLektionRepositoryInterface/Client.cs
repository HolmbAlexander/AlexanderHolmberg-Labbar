using OOPLektionRepositoryInterface.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLektionRepositoryInterface
{
    class Client
    {
        public void Start()
        {
            var games = new GamesController();
            var loop = true;

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        games.CreateGame();
                        break;

                    case ConsoleKey.D2:
                        games.RemoveGame();
                        break;

                    case ConsoleKey.D3:
                        games.PrintGamesList();
                        break;

                    case ConsoleKey.D4:
                        games.EditGame();
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
    }
}
