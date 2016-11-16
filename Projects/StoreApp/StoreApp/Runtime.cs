using StoreApp.Lists_and_Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    class Runtime
    {
        public static int totalPrice;
        ListsMenus manager = new ListsMenus();
        public void Start()
        {
            MainMenu();
        }

        void MainMenu()
        {
            bool mainLoop = true;
            while (mainLoop)
            {
                Console.Clear();
                manager.MainMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        ShoppMenu();
                        break;

                    case ConsoleKey.D2:
                        manager.ShowShoppingCart();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:

                        break;

                    case ConsoleKey.D4:
                        mainLoop = false;
                        break;
                }
            }
        }

        void ShoppMenu()
        {
            bool shoopLoop = true;
            while (shoopLoop)
            {
                Console.Clear();
                manager.ProductsMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.ShowInventory("Clothes");
                        manager.BuyClothes();
                        break;

                    case ConsoleKey.D2:
                        manager.ShowInventory("Electronics");
                        manager.BuyElectronics();
                        break;

                    case ConsoleKey.D3:
                        manager.ShowInventory("Food");
                        manager.BuyElectronics();
                        break;

                    case ConsoleKey.D4:
                        shoopLoop = false;
                        break;
                }
            }
        }
    }
}
