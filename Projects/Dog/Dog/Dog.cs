using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Dog()
        {
        }

        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string DogIntroduction()
        {

            return String.Format("This {0}´s name is {1} and is {2} years old.", Breed, Name, Age);
        }
    }
}
