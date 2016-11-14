using DirectivesWorkshop.Filters;
using DirectivesWorkshop.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectivesWorkshop
{
    class Runtime
    {
        public void Start()
        {
            PersonManager manager = new PersonManager();

            PersonFilter isOldFilter = PersonFilters.IsOld;
            PersonFilter isYoungFilter = PersonFilters.IsYoung;
            PersonFilter isNameStartsWithA = PersonFilters.NameStartsWithA;

            Console.WriteLine("Old people: ");
            manager.PrintWhere(isOldFilter);

            Console.WriteLine("\nYoung people: ");
            manager.PrintWhere(isYoungFilter);

            Console.WriteLine("\nName starts with A: ");
            manager.PrintWhere(isNameStartsWithA);

            Console.WriteLine("\nNames with more then 4 letters: ");
            manager.PrintWhere(person => person.Name.Length > 4);
        }
    }
}
