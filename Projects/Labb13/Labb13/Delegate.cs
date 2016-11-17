using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Options
{
    class Delegate
    {
        public delegate bool GameFilter(Games games);
        public delegate void PrintMessage(string message);
    }
}
