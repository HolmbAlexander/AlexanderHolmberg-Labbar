using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Menus
    {
        Runtime runtime = new Runtime();

        public void MainMenu()
        {

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("By: Alexander Holmberg & Pascal Andersson.");
                Console.WriteLine("Welcome to TV-shopping-frenzy-mega-fun-wow-such-great-TV's!");
                Console.WriteLine("1: See products");
                Console.WriteLine("2: Shopping cart add");
                Console.WriteLine("3: Exit");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        runtime.ShowItems();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        runtime.ShoppingCartAdd();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
