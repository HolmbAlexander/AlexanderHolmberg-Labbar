using Labb13.Filters;
using Labb13.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb13.Options.Delegate;

namespace Labb13
{
    class Runtime
    {
        MethodsAndLists manager = new MethodsAndLists();

        GameFilter isOverFilter = GameFilters.isPlayedOver;
        GameFilter isUnderFilter = GameFilters.isPlayedUnder;
        GameFilter isRPGFilter = GameFilters.isGenreRPG;
        GameFilter isFPSFilter = GameFilters.isGenreFPS;
        GameFilter isMMORPGFilter = GameFilters.isGenreMMORPG;
        GameFilter isSIMULATORFilter = GameFilters.isGenreSIMULATOR;

        public void Start()
        {
            
            Menu();
        }

        void Invoke()
        {
            
        }

        void Menu()
        {
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Press a command to continue.");
                Console.WriteLine("1: See list");
                Console.WriteLine("2: Add game");
                Console.WriteLine("3: Search list");
                Console.WriteLine("4: Quit");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        manager.PrintGames();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        manager.AddGame();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        SearchList();
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }

        void SearchList()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1: All games played over 100 hours");
                Console.WriteLine("2: All games played under 100 hours");
                Console.WriteLine("3: Search game");
                Console.WriteLine("4: Go back");
                var input = Console.ReadKey(true).Key;
                switch(input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        manager.PrintWhere(isOverFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        manager.PrintWhere(isUnderFilter);
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        GenreList();
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }

        void GenreList()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1: RPG");
                Console.WriteLine("2: FPS");
                Console.WriteLine("3: Simulator");
                Console.WriteLine("4: MMORPG");
                Console.WriteLine("5: Go back");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        manager.PrintWhere(isRPGFilter);
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        manager.PrintWhere(isFPSFilter);
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        manager.PrintWhere(isSIMULATORFilter);
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        manager.PrintWhere(isMMORPGFilter);
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
    }
}
