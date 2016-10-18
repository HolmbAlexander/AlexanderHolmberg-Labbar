using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Menus
    {
        public void VälkomstMeny()
        {
            bool loop = false;
            do
            {
            Console.WriteLine("Välkommen att boka ditt evangemang!");
            Console.WriteLine("1: Boka evangemang.");
            Console.WriteLine("2: Se dina bokade evangemang.");
            Console.WriteLine("3: Avsluta.");
            var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: ValEvangemang(); break;
                    case ConsoleKey.D2: break;
                    case ConsoleKey.D3: Environment.Exit(0); break;
                    default: Console.Clear(); loop = true; break;
                }
            } while (loop);
        }

        public void ValEvangemang()
        {
            bool loop = false;
            do
            {
                Console.WriteLine("Välj mellan 1-3.");
                Console.WriteLine("1: Boka festival.");
                Console.WriteLine("2: Boka konsert.");
                Console.WriteLine("3: Boka film.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: break;
                    case ConsoleKey.D2: break;
                    case ConsoleKey.D3: break;
                }

            } while (loop);
        }
    }
}
