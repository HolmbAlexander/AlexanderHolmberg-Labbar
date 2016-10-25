using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class UI
    {
        #region Menus
        public static void PrintMainManu()
        {
            Console.Clear();
            Console.WriteLine("Choose what to work with!");
            Console.WriteLine("1: Games");
            Console.WriteLine("2: Movies");
            Console.WriteLine("3: Exit");
        }

        public static void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Add game");
            Console.WriteLine("2: Remove game");
            Console.WriteLine("3: Show all games");
            Console.WriteLine("4: Edit game");
            Console.WriteLine("5: Main menu");
        }

        public static void MovieMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Add movie");
            Console.WriteLine("2: Remove movie");
            Console.WriteLine("3: Show all movies");
            Console.WriteLine("4: Edit movie");
            Console.WriteLine("5: Main menu");
        }

        internal static void PrintGameList(Movie[] movies)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Game Methods
        public static void PrintGamesGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Game.GenreType)))
            {
                Console.WriteLine("{0}: {1}.", (int)genre, genre);
            }
        }

        public static Game CreateGame()
        {
            Game newGame = new Game();
            Console.Clear();
            Console.Write("Game name: ");
            newGame.Name = Console.ReadLine();

            Console.WriteLine("Game genres: ");
            PrintGamesGenres();
            Console.Write("Choose genre: ");
            int input = int.Parse(Console.ReadLine());
            newGame.Genre = (Game.GenreType)input;

            return newGame;
        }

        public static void PrintGameList(Game[] games)
        {
            Console.Clear();
            foreach (var game in games)
            {
                Console.WriteLine("{0}: Game: {1}. Genre: {2}.", 
                    Array.IndexOf(games, game)+1,
                    game.Name,
                    game.Genre);
            }
        }

        public static int SelectGame(Game[] games)
        {
            PrintGameList(games);
            Console.Write("Select game: ");
            return int.Parse(Console.ReadLine());
        }

        public static void EditGame(Game game)
        {
            Console.Clear();
            Console.WriteLine("1: Change name");
            Console.WriteLine("2: Change genre");
            Console.WriteLine("3: Change both");
            Console.WriteLine("Choice: ");
            var input = Console.ReadKey(true).Key;
            Console.Clear();

            switch (input)
            {
                case ConsoleKey.D1:
                    
                    Console.Write("New name: ");
                    game.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre List: ");
                    PrintGamesGenres();
                    Console.Write("New genre: ");
                    game.Genre = (Game.GenreType)int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("New name: ");
                    game.Name = Console.ReadLine();

                    Console.WriteLine("Genre List: ");
                    PrintGamesGenres();
                    Console.Write("New genre: ");
                    game.Genre = (Game.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
            
        }
        #endregion

        #region Movie Methods
        public static void PrintMoviesGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Movie.GenreType)))
            {
                Console.WriteLine("{0}: {1}.", (int)genre, genre);
            }
        }

        public static Movie CreateMovie()
        {
            Movie newMoive = new Movie();
            Console.Clear();
            Console.Write("Name: ");
            newMoive.Name = Console.ReadLine();

            Console.WriteLine("Genres: ");
            PrintMoviesGenres();
            Console.Write("Genre: ");
            int input = int.Parse(Console.ReadLine());
            newMoive.Genre = (Movie.GenreType)input;

            return newMoive;
        }

        public static void PrintMovieList(Movie[] movies)
        {
            Console.Clear();
            foreach (var movie in movies)
            {
                Console.WriteLine("{0}: Movie: {1}. Genre: {2}.",
                    Array.IndexOf(movies, movie)+1,
                    movie.Name,
                    movie.Genre);
            }
        }

        public static int SelectMovie(Movie[] movies)
        {
            PrintMovieList(movies);
            Console.Write("Select movie: ");
            return int.Parse(Console.ReadLine());
        }

        public static void EditMovie(Movie movie)
        {
            Console.Clear();
            Console.WriteLine("1: Change name");
            Console.WriteLine("2: Change genre");
            Console.WriteLine("3: Change both");
            Console.WriteLine("Choice: ");
            var input = Console.ReadKey(true).Key;
            Console.Clear();

            switch (input)
            {
                case ConsoleKey.D1:

                    Console.Write("New name: ");
                    movie.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre List: ");
                    PrintGamesGenres();
                    Console.Write("New genre: ");
                    movie.Genre = (Movie.GenreType)int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("New name: ");
                    movie.Name = Console.ReadLine();

                    Console.WriteLine("Genre List: ");
                    PrintGamesGenres();
                    Console.Write("New genre: ");
                    movie.Genre = (Movie.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }
        #endregion
    }
}
