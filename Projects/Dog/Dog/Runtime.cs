using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Runtime
    {
        List<Dog> dogs = new List<Dog>()
            {
            new Dog { Name = "Fido", Age = 6, Breed = "Pitbull" },
            new Dog { Name = "Bubben", Age = 2, Breed = "Golden Retriver" },
            new Dog { Name = "Schmitzel", Age = 4, Breed = "Weiner" },
            };

        public void Start()
        {
            Menu();

        }
        private void Menu()
        {
            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Press a number beetwen 1-4 to continue...");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Add dog");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Remove dog");
                        break;
                    case ConsoleKey.D3:
                        ShowDogs();
                        break;
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                    default:
                        loop = true;
                        break;
                }
            } while (loop);
        }
        void ShowDogs()
        {
            foreach (var Dog in dogs)
            {
                Console.WriteLine(Dog.DogIntroduction());
                Console.WriteLine();
            }
        }
    }
}
