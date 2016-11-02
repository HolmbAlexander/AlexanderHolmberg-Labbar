using BasicInterface.Classes;
using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface
{
    class Runtime
    {
        public void Start()
        {
            #region Old Stuff
            //IFlyable bird = new Bird();
            //IFlyable plane = new Plane();

            //bird.Fly();
            //plane.Fly();
            #endregion

            // Typing an object variable to an interface means we can treat
            // all classes/object implementing this interface the same way.
            // For ecample we may add different classes to a List of interfaces.
            // The downside is that we cannot acces properties or methods that
            // are specific for Brid or Plane without type casting.
            List<IFlyable> flyingThings = new List<IFlyable>
            {
                new Bird { Color = "red", TopSpeed = 45 },
                new Plane { TopSpeed = 1000 }
            };

            Console.WriteLine("Flying things: ");
            foreach (var flyingThing in flyingThings)
            {
                #region Will crash when we get to Plane
                //Console.WriteLine(((Bird)flyingThing).Color);
                #endregion

                flyingThing.Fly();
                Console.WriteLine("At the speed {0}", flyingThing.TopSpeed);
            }


            List<ISpeakable> speakableThings = new List<ISpeakable>
            {
                new Bird { Color = "Blue", TopSpeed = 35 },
                new Person(),
                new Dog()
            };

            Console.WriteLine("\nSpeakable things: ");
            foreach (var speakableThing in speakableThings)
            {
                Console.WriteLine(speakableThing.Speak());
            }
        }
    }
}
