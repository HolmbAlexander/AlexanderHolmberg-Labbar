using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Runtime
    {
        List<Dog> dogList = new List<Dog>();
        bool gameLoop = false;
        public void Start()
        {
            do
            {
                Menu();
            } while (gameLoop == false);
        }
        void Menu()
        {
            bool loop = false;
            do
            {
                MenuText();

                loop = false;
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        AddDog();
                        break;
                    case ConsoleKey.D2:
                        RemoveDog();
                        break;
                    case ConsoleKey.D3:
                        ShowDogs();
                        break;
                    case ConsoleKey.D4:
                        gameLoop = true;
                        break;
                    default:
                        Console.Clear();
                        loop = true;
                        break;
                }
            } while (loop);
        }
        void MenuText()
        {
            Console.Clear();
            Console.WriteLine("1: Add a dog to list");
            Console.WriteLine("2: Remove a dog from list");
            Console.WriteLine("3: Show list of all dogs");
            Console.WriteLine("4: Quit");
            Console.WriteLine();
            Console.WriteLine("Press a number between 1-4 to continue...");
        }
        void ShowDogs()
        {
            Console.Clear();
            int i = 0;
            foreach (var Dog in dogList)
            {
                Console.WriteLine(i + Dog.DogIntroduction());
                
                i++;
            }
            Console.ReadLine();
            
        }
        void AddDog()
        {
            Console.Clear();
            Console.Write("Breed: ");
            string breed = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age(in human years): ");
            int age = int.Parse(Console.ReadLine());

            Dog newDog = new Dog
            {
                Breed = breed,
                Name = name,
                Age = age
            };
            dogList.Add(newDog);
        }
        void RemoveDog()
        {
            ShowDogs();
            Console.WriteLine("Enter a number you like to remove: ");
            int input = int.Parse(Console.ReadLine());
            dogList.RemoveAt(input);
            Console.Clear();
        }
    }
}
