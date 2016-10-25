using Labb5.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Client
    {
        public void Start()
        {
            var games = new GamesController();
            var movies = new MoviesController();
            var loop = true;

            while(loop)
            {
                UI.PrintMainManu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        bool isGameLoop = true;
                        while(isGameLoop)
                        {
                            UI.GameMenu();
                            var inputGame = Console.ReadKey(true).Key;
                            switch (inputGame)
                            {
                                case ConsoleKey.D1: games.CreateGame();     break;

                                case ConsoleKey.D2: games.RemoveGame();     break;

                                case ConsoleKey.D3: games.PrintGameList();  break;

                                case ConsoleKey.D4: games.EditGame();       break;

                                case ConsoleKey.D5: isGameLoop = false;     break;
                            }
                        }
                        break;

                    case ConsoleKey.D2:
                        bool isMovieLoop = true;
                        while (isMovieLoop)
                        {
                            UI.MovieMenu();
                            var inputMovie = Console.ReadKey(true).Key;
                            switch (inputMovie)
                            {
                                case ConsoleKey.D1: movies.CreateMovie();       break;

                                case ConsoleKey.D2: movies.RemoveMovie();       break;

                                case ConsoleKey.D3: movies.PrintMoviesList();   break;

                                case ConsoleKey.D4: movies.EditMovie();         break;

                                case ConsoleKey.D5: isMovieLoop = false;        break;
                            }
                        }
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
