using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabb2
{
    class Runtime
    {
        Menus menus = new Menus();
        List<LandAnimals> landAnimalsList = new List<LandAnimals>();
        List<WaterAnimals> waterAnimalsList = new List<WaterAnimals>();
        List<Reptiles> reptilesList = new List<Reptiles>();
        List<Insects> insectsList = new List<Insects>();
        List<Birds> birdsList = new List<Birds>();
        bool gameLoop = false;

        public void Start()
        {
            Cats firstLandLandAnimal = new Cats { Name = "Noweigan forest cat", LifeSpan = 10, Movement = "Moves by walking and running", Food = "Carnivour", Fur = "Yes", NumberOfLegs = 4, Clean = "With tounge" }; landAnimalsList.Add(firstLandLandAnimal);
            Parrots firstBird = new Parrots { Name = "African Singingparrot", LifeSpan = 15, Movement = "Flying and walking very short distances", Food = "Herbivore", FlyingAbility = "Yes", Sing = "Yes", Talk = "Yes"}; birdsList.Add(firstBird);
            Sharks firstShark = new Sharks { Name = "Great White", LifeSpan = 30, Movement = "Swimming", Food = "Carnivore", Breed = "Mating with female", Reproduce = "Giving birth to live babysharks?", Watertype = "Saltwater"}; waterAnimalsList.Add(firstShark);
            Ants firstAnt = new Ants { Name = "Fireant", LifeSpan = 1, Food = "Carnivore", Movement = "Walks and runs", Lift = 10, LivesInNest = "Yes", NumberOfLegs = 6}; insectsList.Add(firstAnt);
            Snakes firstSnake = new Snakes { Name = "Anaconda", Movement = "Slithers/crawls", Food = "Carnivore", LifeSpan = 10, Reproduce = "Lays eggs", ShreddsSkin = "Yes", Venomous = "No"}; reptilesList.Add(firstSnake);

            do
            {
                Meny();
            } while (gameLoop == false);
        }
        void Meny()
        {
            bool loop = false;
            do
            {
                
                menus.MenuText();
                loop = false;
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1: AnimalMenu(); break;
                    case ConsoleKey.D2: RemoveAnimal(); break;
                    case ConsoleKey.D3: ShowAnimal(); break;
                    case ConsoleKey.D4: gameLoop = true; break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
        void AnimalMenu()
        {
            bool loop = false;
            do
            {
                menus.MenuChooseAnimal();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1: AddLandAnimal(); break;
                    case ConsoleKey.D2: AddWaterAnimal(); break;
                    case ConsoleKey.D3: AddInsect(); break;
                    case ConsoleKey.D4: AddBird(); break;
                    case ConsoleKey.D5: AddReptile(); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
        #region Add animal methods
        void AddReptile()
        {
            Console.Clear();
            Console.WriteLine("Name of the animal: ");
            string name = Console.ReadLine();
            Console.Write("What kind of food does it eat: ");
            string food = Console.ReadLine();
            Console.Write("Whats the average lifetime(in numbers): ");
            int lifeSpan = int.Parse(Console.ReadLine());
            Console.Write("How does the animal move: ");
            string movement = Console.ReadLine();
            Console.Write("How does the animal reproduce: ");
            string repoduce = Console.ReadLine();
            Console.Write("Does the animal shredd skin: ");
            string shreddsSkin = Console.ReadLine();
            Console.Write("Is your animal venomous: ");
            string venomous = Console.ReadLine();

            Snakes addReptiles = new Snakes
            { Name = name, Food = food, LifeSpan = lifeSpan, Movement = movement, Reproduce = repoduce, ShreddsSkin = shreddsSkin, Venomous = venomous };
            reptilesList.Add(addReptiles);
        }
        void AddLandAnimal()
        {
            Console.Clear();
            Console.WriteLine("Name of the animal: ");
            string name = Console.ReadLine();
            Console.Write("What kind of food does it eat: ");
            string food = Console.ReadLine();
            Console.Write("Whats the average lifetime(in numbers): ");
            int lifeSpan = int.Parse(Console.ReadLine());
            Console.Write("How does the animal move: ");
            string movement = Console.ReadLine();
            Console.Write("Does it have fur: ");
            string fur = Console.ReadLine();
            Console.Write("Number of legs(answer with a number): ");
            int numberOfLegs = int.Parse(Console.ReadLine());
            Console.Write("How does it clean itself: ");
            string clean = Console.ReadLine();

            Cats addLandAnimals = new Cats
            { Name = name, Food = food, LifeSpan = lifeSpan, Movement = movement, Fur = fur, NumberOfLegs = numberOfLegs, Clean = clean };
            landAnimalsList.Add(addLandAnimals);
            
        }
        void AddWaterAnimal()
        {
            Console.Clear();
            Console.WriteLine("Name of the animal: ");
            string name = Console.ReadLine();
            Console.Write("What kind of food does it eat: ");
            string food = Console.ReadLine();
            Console.Write("Whats the average lifetime(in numbers): ");
            int lifeSpan = int.Parse(Console.ReadLine());
            Console.Write("How does the animal move: ");
            string movement = Console.ReadLine();
            Console.Write("How does it reproduce: ");
            string reproduce = Console.ReadLine();
            Console.Write("What kind of water does it live in: ");
            string watertype = Console.ReadLine();
            Console.Write("What kind is it: ");
            string breed = Console.ReadLine();

            Sharks addWateranimal = new Sharks
            { Name = name, Food = food, LifeSpan = lifeSpan, Movement = movement, Reproduce = reproduce, Watertype = watertype, Breed = breed };
            waterAnimalsList.Add(addWateranimal);
        }
        void AddBird()
        {
            Console.Clear();
            Console.WriteLine("Name of the animal: ");
            string name = Console.ReadLine();
            Console.Write("What kind of food does it eat: ");
            string food = Console.ReadLine();
            Console.Write("Whats the average lifetime(in numbers): ");
            int lifeSpan = int.Parse(Console.ReadLine());
            Console.Write("How does the animal move: ");
            string movement = Console.ReadLine();
            Console.Write("Can it fly: ");
            string flyingAbility = Console.ReadLine();
            Console.Write(@"Does it sing with birdcalls: ");
            string sing = Console.ReadLine();
            Console.Write("Can it talk: ");
            string talk = Console.ReadLine();

            Parrots addParrots = new Parrots
            { Name = name, Food = food, LifeSpan = lifeSpan, Movement = movement, FlyingAbility = flyingAbility, Sing = sing, Talk = talk };
            birdsList.Add(addParrots);
        }
        void AddInsect()
        {
            Console.Clear();
            Console.WriteLine("Name of the animal: ");
            string name = Console.ReadLine();
            Console.Write("What kind of food does it eat: ");
            string food = Console.ReadLine();
            Console.Write("Whats the average lifetime(in numbers): ");
            int lifeSpan = int.Parse(Console.ReadLine());
            Console.Write("How does the animal move: ");
            string movement = Console.ReadLine();
            Console.Write("Does it live in a nest: ");
            string livesInNest = Console.ReadLine();
            Console.Write("Number of legs(answer with a number): ");
            int numberOfLegs = int.Parse(Console.ReadLine());
            Console.Write("How many times can it lift it´s own weight(answer with a number): ");
            double lift = double.Parse(Console.ReadLine());

            Ants addAnts = new Ants
            { Name = name, Food = food, LifeSpan = lifeSpan, Movement = movement, LivesInNest = livesInNest, NumberOfLegs = numberOfLegs, Lift = lift };
            insectsList.Add(addAnts);
        }
        #endregion
        #region Show animals methods
        void ShowLandAnimals()
        {
            Console.Clear();
            int i = 1;
            foreach (var Animal in landAnimalsList)
            {
                Console.WriteLine(i + ": " + Animal.BasicInfo()); i++;
            }
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }
        void ShowWaterAnimals()
        {
            Console.Clear();
            int i = 1;
            foreach (var Animal in waterAnimalsList)
            {
                Console.WriteLine(i + ": " + Animal.BasicInfo()); i++;
            }
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }
        void ShowBirds()
        {
            Console.Clear();
            int i = 1;
            foreach (var Animal in birdsList)
            {
                Console.WriteLine(i + ": " + Animal.BasicInfo()); i++;
            }
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }
        void ShowInsects()
        {
            Console.Clear();
            int i = 1;
            foreach (var Animal in insectsList)
            {
                Console.WriteLine(i + ": " + Animal.BasicInfo()); i++;
            }
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }
        void ShowReptiles()
        {
            Console.Clear();
            int i = 1;
            foreach (var Animal in reptilesList)
            {
                Console.WriteLine(i + ": " + Animal.BasicInfo()); i++;
            }
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }
        #endregion
        void ShowAnimal()
        {
            bool loop = false;
            do
            {
            menus.MenuShowAnimalText();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1: ShowLandAnimals(); break;
                case ConsoleKey.D2: ShowWaterAnimals(); break;
                case ConsoleKey.D3: ShowInsects(); break;
                case ConsoleKey.D4: ShowBirds(); break;
                case ConsoleKey.D5: ShowReptiles(); break;
                    default: Console.Clear(); loop = true; break;
            }
        } while (loop);

        }
        #region Remove Animals methods
        void RemoveLandAnimals()
        {
            ShowLandAnimals();
            Console.Write("Which index would you like to remove? ");
            int input = int.Parse(Console.ReadLine());
            landAnimalsList.RemoveAt(input - 1);
        }
        void RemoveWaterAnimals()
        {
            ShowWaterAnimals();
            Console.Write("Which index would you like to remove? ");
            int input = int.Parse(Console.ReadLine());
            waterAnimalsList.RemoveAt(input - 1);
        }
        void RemoveBirds()
        {
            ShowBirds();
            Console.Write("Which index would you like to remove? ");
            int input = int.Parse(Console.ReadLine());
            birdsList.RemoveAt(input - 1);
        }
        void RemoveInsects()
        {
            ShowInsects();
            Console.Write("Which index would you like to remove? ");
            int input = int.Parse(Console.ReadLine());
            insectsList.RemoveAt(input - 1);
        }
        void RemoveReptiles()
        {
            ShowLandAnimals();
            Console.Write("Which index would you like to remove? ");
            int input = int.Parse(Console.ReadLine());
            reptilesList.RemoveAt(input - 1);
        }
#endregion
        void RemoveAnimal()
        {
            menus.MenuRemoveAnimal();
            bool loop = false;
            do
            {
                menus.MenuShowAnimalText();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1: RemoveLandAnimals(); break;
                    case ConsoleKey.D2: RemoveWaterAnimals(); break;
                    case ConsoleKey.D3: RemoveInsects(); break;
                    case ConsoleKey.D4: RemoveBirds(); break;
                    case ConsoleKey.D5: RemoveReptiles(); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }
    }
}
