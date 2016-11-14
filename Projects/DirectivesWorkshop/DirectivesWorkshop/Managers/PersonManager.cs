using DirectivesWorkshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectivesWorkshop.Managers
{
    class PersonManager
    {
        public List<Person> People { get; set; }

        public PersonManager()
        {
            People = new List<Person>
            {
                new Person { Name = "Frank", Age = 41 },
                new Person { Name = "Anna",  Age = 28 },
                new Person { Name = "Steve", Age = 68 },
                new Person { Name = "Agda",  Age = 32 }
            };
        }

        public void PrintWhere(PersonFilter filter)
        {
            foreach (var person in People)
            {
                if (filter(person))
                    Console.WriteLine(person.Name);
            }
        }


    }
}
