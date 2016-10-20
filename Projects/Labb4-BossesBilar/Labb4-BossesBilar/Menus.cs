using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_BossesBilar
{
    class Menus
    {
        VehicleManager manager = new VehicleManager();

        public void WelcomeMenu()
        {
            bool loop = false;
            do
            { 

            Console.Clear();
            Console.WriteLine("Welcome to Bosses cars and bikes. We promise we wont scam you!");
            Console.WriteLine("1: Add vehicle.");
            Console.WriteLine("2: See vehicles.");
            Console.WriteLine("3: Remove vehicle.");
            Console.WriteLine("4: Buy vehicle.");
            Console.WriteLine("5: Sell vehicle.");
            Console.WriteLine("6: Exit.");
            var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: AddMenu(); loop = true; break;
                    case ConsoleKey.D2: ShowVehicleMenu(); loop = true; break;
                    case ConsoleKey.D3: RemoveVehicleMenu(); loop = true; break;
                    case ConsoleKey.D4: BuyVehicle(); loop = true; break;
                    case ConsoleKey.D5: SellVehicle(); loop = true; break;
                    case ConsoleKey.D6: Environment.Exit(0); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        void AddMenu()
        {
            bool loop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose what to add...");
                Console.WriteLine("1: Add new car.");
                Console.WriteLine("2: Add used car.");
                Console.WriteLine("3: Add new bike.");
                Console.WriteLine("4: Add used bike.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: manager.AddNewCar(); loop = false; break;
                    case ConsoleKey.D2: manager.AddUsedCar(); loop = false; break;
                    case ConsoleKey.D3: manager.AddNewBike(); loop = false; break;
                    case ConsoleKey.D4: manager.AddUsedBike(); loop = false; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
            
        }

        public void ShowVehicleMenu()
        {
            bool loop = false;
            do {
                Console.Clear();
                Console.WriteLine("What vehicles would you like to see inventory of?");
                Console.WriteLine("1: New cars");
                Console.WriteLine("2: Used cars");
                Console.WriteLine("3: New bikes");
                Console.WriteLine("4: Used bikes");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: manager.ShowNewCar(); Console.ReadKey(true); loop = false; break;
                    case ConsoleKey.D2: manager.ShowUsedCar(); Console.ReadKey(true); loop = false; break;
                    case ConsoleKey.D3: manager.ShowNewBike(); Console.ReadKey(true); loop = false; break;
                    case ConsoleKey.D4: manager.ShowUsedBike(); Console.ReadKey(true); loop = false; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        public void RemoveVehicleMenu()
        {
            bool loop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("What vehicle would you like to remove?");
                Console.WriteLine("1: New cars");
                Console.WriteLine("2: Used cars");
                Console.WriteLine("3: New bikes");
                Console.WriteLine("4: Used bikes");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: manager.RemoveNewCar(); loop = false; break;
                    case ConsoleKey.D2: manager.RemoveUsedCar(); loop = false; break;
                    case ConsoleKey.D3: manager.RemoveNewBike(); loop = false; break;
                    case ConsoleKey.D4: manager.RemoveUsedBike(); loop = false; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        public void BuyVehicle()
        {
            bool loop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("What vehicle would you like to buy?");
                Console.WriteLine("1: New cars");
                Console.WriteLine("2: Used cars");
                Console.WriteLine("3: New bikes");
                Console.WriteLine("4: Used bikes");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: manager.BuyNewCar(); loop = false; break;
                    case ConsoleKey.D2: manager.BuyUsedCar(); loop = false; break;
                    case ConsoleKey.D3: manager.BuyNewBike(); loop = false; break;
                    case ConsoleKey.D4: manager.BuyUsedBike(); loop = false; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        public void SellVehicle()
        {
            bool loop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("What vehicle would you like to sell?");
                Console.WriteLine("1: New cars");
                Console.WriteLine("2: Used cars");
                Console.WriteLine("3: New bikes");
                Console.WriteLine("4: Used bikes");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: manager.SellNewCar(); loop = false; break;
                    case ConsoleKey.D2: manager.SellUsedCar(); loop = false; break;
                    case ConsoleKey.D3: manager.SellNewBike(); loop = false; break;
                    case ConsoleKey.D4: manager.SellUsedBike(); loop = false; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
    }
}
