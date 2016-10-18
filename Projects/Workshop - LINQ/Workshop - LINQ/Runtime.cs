using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop___LINQ
{
    class Runtime
    {
        public void Start()
        {
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "John",    LastName = "Fridstedt",  Age = 24, City = "Stockholm" },
                new Person { FirstName = "Niklas",  LastName = "Anderson",   Age = 24, City = "Stockholm" },
                new Person { FirstName = "Anna",    LastName = "Schmidt",    Age = 24, City = "Stockholm" },
                new Person { FirstName = "Johanna", LastName = "Kullberg",   Age = 24, City = "Stockholm" },
                new Person { FirstName = "John",    LastName = "Smith",      Age = 24, City = "Stockholm" },
                new Person { FirstName = "Niklas",  LastName = "Petterson",  Age = 24, City = "Stockholm" },
                new Person { FirstName = "Nisse",   LastName = "Andersson",  Age = 24, City = "Stockholm" },
                new Person { FirstName = "John",    LastName = "Wayne",      Age = 24, City = "Stockholm" },
            };

            #region SingleOrDefault
            // "SingleOrDeafult" returns a single instance of an object inside a
            // collenction that matches a condition.
            // If there are more than ine objects matching the condition inside the collection
            // the program will throw an exception.
            #endregion
            Person singlePerson = people.SingleOrDefault(person => String.Equals(person.ToString(), "John Fridstedt"));
            #region alternative output
            //string output;
            //if (singlePerson != null)
            //    output = singlePerson.ToString();
            //else
            //    output = "No matches";
            #endregion
            Console.WriteLine("SingleOrDefault: {0}", singlePerson != null ? singlePerson.ToString() : "no matches");

            #region Where
            // "Where" returns a subset of subject that fulfills a certain condition
            Person[] subset = people
                .Where(person => person.FirstName.Contains("John"))
                .ToArray();

            foreach (var person in subset)
            {
                Console.WriteLine("Where: {0}: ", person.ToString());
            }
            #endregion
            #region Select
            // Select allows us to go through a collection and map properties
            // of objects to different objects.
            // We then get a new collection of the new type.
            PersonMeta[] peopleMeta = people
                .Select(person => new PersonMeta { FullName = person.ToString() })
                .ToArray();

            string[] firstNames = people
                .Select(person => person.FirstName)
                .ToArray();

            foreach (var meta in peopleMeta)
            {
                Console.WriteLine("MetaData: {0}", meta.FullName);
            }

            foreach (var firstName in firstNames)
            {
                Console.WriteLine("First names: {0}", firstName);
            }
            #endregion

            #region Chaining
            // We may chain these methods together, as long as we start with the ones
            // return the larger subset; IE Where -> Select -> Single/First
            string[] allNiklas = people
                .Where(person => String.Equals(person.FirstName, "Niklas")) // First select all objects with first name "Niklas
                .Select(person => person.FirstName) // Then map the first name of eac person to a string
                .ToArray();

            foreach (var niklas in allNiklas)
            {
                Console.WriteLine("Niklas: {0}", niklas);
            }
            #endregion

            #region Remove example
            // The Remove() method in List expects an object parameter.
            // We can use LINQ to find the object we want to remove and use it with
            // the Remove() method.
            Person personToRemove = people
                .SingleOrDefault(person => String.Equals(person.ToString(), "John Fridstedt"));

            people.Remove(personToRemove);

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
            #endregion
        }
        #region Lambda "explained"
        //public bool MyFunction(Person person)
        //{
        //    if (person.FirstName.Contains("John"))
        //        return true;

        //        return false;
        //}
        #endregion
    }
}

