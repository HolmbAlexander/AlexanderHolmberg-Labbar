using Labb15.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15
{
    class Runtime
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Spaceship spaceship = new Spaceship();
        Boulder boulder = new Boulder();
        Button button = new Button();
        int choice;

        public void Start()
        {
            MainMenu();
        }

        void MainMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1: See things that can be pushed");
                Console.WriteLine("2: See vehicles");
                Console.WriteLine("3: Exit");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        PushSomethingMenu();
                        break;

                    case ConsoleKey.D2:
                        SeeVehicle();
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }

        void PushSomethingMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("What do you wanna push big boy?");
                Console.WriteLine("1: Push button");
                Console.WriteLine("2: Push rock");
                Console.WriteLine("3: Dont push anyhing. You wuz...");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(button.Push());
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine(boulder.Push());
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }

        void SeeVehicle()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("What do you wanna interact with...");
                Console.WriteLine("1: Car");
                Console.WriteLine("2: Bicycle");
                Console.WriteLine("3: Spaceship");
                Console.WriteLine("4: Go back");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        choice = 1;
                        InteractVehicle();
                        break;

                    case ConsoleKey.D2:
                        choice = 2;
                        InteractVehicle();
                        break;

                    case ConsoleKey.D3:
                        choice = 3;
                        InteractVehicle();
                        break;

                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }

        void InteractVehicle()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("What do you wanna do...");
                Console.WriteLine("1: Start");
                Console.WriteLine("2: Stop");
                Console.WriteLine("3: Lock");
                Console.WriteLine("4: Unlock");
                Console.WriteLine("5: Go back");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        if (choice == 1)
                        { Console.WriteLine(car.Start()); Console.ReadKey(true); }
                        else if (choice == 2)
                        { Console.WriteLine(bicycle.Start()); Console.ReadKey(true); }
                        else if (choice == 3)
                        { Console.WriteLine(spaceship.Start()); Console.ReadKey(true); }
                            break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        if (choice == 1)
                        { Console.WriteLine(car.Stop()); Console.ReadKey(true); }
                        else if (choice == 2)
                        { Console.WriteLine(bicycle.Stop()); Console.ReadKey(true); }
                        else if (choice == 3)
                        { Console.WriteLine(spaceship.Stop()); Console.ReadKey(true); }
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        if (choice == 1)
                        { Console.WriteLine(car.Lock()); Console.ReadKey(true); }
                        else if (choice == 2)
                        { Console.WriteLine(bicycle.Lock()); Console.ReadKey(true); }
                        else if (choice == 3)
                        { Console.WriteLine(spaceship.Lock()); Console.ReadKey(true); }
                            break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        if (choice == 1)
                        { Console.WriteLine(car.Unlock()); Console.ReadKey(true); }
                        else if (choice == 2)
                        { Console.WriteLine(bicycle.Unlock()); Console.ReadKey(true); }
                        else if (choice == 3)
                        { Console.WriteLine(spaceship.Unlock()); Console.ReadKey(true); }
                            break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
    }
}
