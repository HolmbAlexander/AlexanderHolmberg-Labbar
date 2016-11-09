using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesWorkshop
{
    class Runtime
    {
        // Declare the delegate "MyDelegate" wich will accept a methid with
        // one string input and return type void.
        public delegate void MyDelegate(string message);

        // This method matches both the return type and inputs of MeDelegate
        // and as such can be used when defining the value.
        public void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            #region Delegates
            /* There are 4 ways to define a delegate from different versions of C# */

            // Delegates in C# v1.0
            MyDelegate del1 = new MyDelegate(DelegateMethod);

            // C# v2.0 - Recommended
            MyDelegate del2 = DelegateMethod;

            // C# v2.0 delegate with anonymous method
            MyDelegate del3 = delegate (string message)
            {
                Console.WriteLine(message);
            };

            // C# v3.0 delegate method using lamba expression - Also recommended
            MyDelegate del4 = (message) =>
            {
                Console.WriteLine(message);
            };

            del1("Hello world!");

            MyClass myObject = new MyClass();

            myObject.Test(del4);
            #endregion

            #region Action and Func
            // Action is a kind of delegate that may have any number of input parameters
            // but no return type.
            Action<string> myAction = (message) =>
            {
                Console.WriteLine(message);
            };

            myObject.ActionTest(myAction);

            // Func may also take any number of inputs but must always have a return type,
            // the last type in the Func declaration decides what the return type will be.
            Func<int, int, int> myFunc = (n1, n2) =>
            {
                return n1 + n2;
            };

            myObject.Calculator(myFunc);

            Func<int, int, int> myFunc2 = (n1, n2) =>
            {
                return n1 * n2;
            };

            myObject.Calculator(myFunc2);
            #endregion

            #region Find and Where
            string result = myObject.Find(word => String.Equals(word, "String 2"));

            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("Null");

            string[] whereResult = myObject.Where(word => word.Contains("String"));

            foreach (var word in whereResult)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region  Counter

            var loop = true;
            var counter = new Counter { Threshold = 3 };

            counter.ThresholdReached += (sender, e) =>
            {
                //Console.WriteLine("WARNING VALUE TO HIGH!");

                Console.WriteLine("Threshold reached, aborting");
                loop = false;
            };

            counter.ThresholdReached += (sender, e) =>
            {
                Console.WriteLine("Second");
            };

            while (loop)
            {
                Console.WriteLine("Total: {0}", counter.Total);
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        counter.Add(1);
                        break;

                    case ConsoleKey.DownArrow:
                        counter.Add(-1);
                        break;
                }
            }

            #endregion
        }
    }
}
