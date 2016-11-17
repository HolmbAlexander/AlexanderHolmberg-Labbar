using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb13.Options.Delegate;

namespace Labb13.Options
{
    class MethodsAndLists
    {
        public event PrintMessage InvalidInput;

        public void CheckGameHours(string message)
        {
            Console.WriteLine(message);
        }

        List<Games> gamesList = new List<Games>
        {
            new Games { Title = "Witcher 3", Genre = "RPG", HoursPlayed = 87 },
            new Games { Title = "CS:GO", Genre = "FPS", HoursPlayed = 835 },
            new Games { Title = "Farming Simulator", Genre = "SIMULATOR", HoursPlayed = 1 },
            new Games { Title = "World Of Warcraft", Genre = "MMORPG", HoursPlayed = 2478 },
            new Games { Title = "Battlefield 1", Genre = "FPS", HoursPlayed = 250 }
        };

        public void AddGame()
        {
            InvalidInput = CheckGameHours;

            Console.Write("Name of the game you would like to add: ");
            string title = Console.ReadLine();
            Console.WriteLine("Genre of the game: ");
            Console.WriteLine("1: RPG");
            Console.WriteLine("2: FPS");
            Console.WriteLine("3: MMORPG");
            Console.WriteLine("4: SIMULATOR");
            string genre;
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1: genre = "RPG"; break;
                case ConsoleKey.D2: genre = "FPS"; break;
                case ConsoleKey.D3: genre = "MMORPG"; break;
                case ConsoleKey.D4: genre = "SIMULATOR"; break;
                default: genre = "No genre"; break;
            }
            int hours;
            bool isInvalid = true;
            
            Console.Write("Number of hours played: ");
            isInvalid = int.TryParse(Console.ReadLine(), out hours);
            if (hours < 0)
            {
                isInvalid = false;
            }
            if (!isInvalid)
            {
                InvalidInput.Invoke("Invalid input. Could not save game!");
                Console.ReadLine();
            }

            if (isInvalid)
            {
                Games addGame = new Games
                {
                    Title = title,
                    Genre = genre,
                    HoursPlayed = hours
                };
                gamesList.Add(addGame);
            }
        }

        public void PrintGames()
        {
            foreach (var game in gamesList)
            {
                Console.WriteLine("Title: {0}. Genre: {1}. Hours played: {2}.",
                                  game.Title,
                                  game.Genre,
                                  game.HoursPlayed);
            }
        }

        public void PrintWhere(GameFilter filter)
        {
            foreach (var game in gamesList)
            {
                if (filter(game))
                {
                    Console.WriteLine(game.Title);
                }
            }
        }
    }
}
