using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMadeSimple
{
    public delegate void PrintMessage();

    class Runtime
    {
        // Declare an event by using the 'event'-keyword followed by the
        // event handler delegate type. The name of an event should describe
        // the condition for raising the evnt.
        private event PrintMessage ApplicationStarted;

        public void Start()
        {
            ApplicationStarted += new PrintMessage(Message1);
            ApplicationStarted += new PrintMessage(Message2);

            OnApplicatonStarted();

            // ? felhantering
            //ApplicationStarted?.Invoke();
        }

        private void OnApplicatonStarted()
        {
            ApplicationStarted.Invoke();
        }

        public void Message1()
        {
            Console.WriteLine("Welcome to this super cool application.");
        }

        public void Message2()
        {
            Console.WriteLine("Everythig is fine, all systems nominal.");
        }
    }
}
