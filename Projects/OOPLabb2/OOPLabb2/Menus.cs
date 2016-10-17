using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabb2
{
    public class Menus
    {
        public void MenuChooseAnimal()
        {
            Console.Clear();
            Console.WriteLine("1: Land animal (Cat)");
            Console.WriteLine("2: Water animal (Shark)");
            Console.WriteLine("3: Insect (Ant)");
            Console.WriteLine("4: Bird (Parrot)");
            Console.WriteLine("5: Reptile (Snake)");
        }

        public void MenuText()
        {
            Console.Clear();
            Console.WriteLine("1: Add a animal to list");
            Console.WriteLine("2: Remove a animal from list");
            Console.WriteLine("3: Show animals");
            Console.WriteLine("4: Quit");
            Console.WriteLine();
            Console.WriteLine("Press a number between 1-4 to continue...");
        }

        public void MenuShowAnimalText()
        {
            Console.Clear();
            Console.WriteLine("What kind of animal would you like to see");
            Console.WriteLine("1: Land animal (Cat)");
            Console.WriteLine("2: Water animal (Shark)");
            Console.WriteLine("3: Insect (Ant)");
            Console.WriteLine("4: Bird (Parrot)");
            Console.WriteLine("5: Reptile (Snake)");
            Console.Write("Enter a number for what list you like to see...");
        }

        public void MenuRemoveAnimal()
        {
            Console.Clear();
            Console.WriteLine("What kind of animal would you like to remove?");
            Console.WriteLine("1: Land animal (Cat)");
            Console.WriteLine("2: Water animal (Shark)");
            Console.WriteLine("3: Insect (Ant)");
            Console.WriteLine("4: Bird (Parrot)");
            Console.WriteLine("5: Reptile (Snake)");
            Console.Write("Enter a number for what animal you'd like to remove...");
        }
    }
}
