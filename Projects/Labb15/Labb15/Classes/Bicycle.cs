using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Bicycle : IVehicle
    {
        public string Start()
        {
            return "You start paddeling...";
        }
        public string Stop()
        {
            return "You stop paddeling...";
        }
        public string Lock()
        {
            return "You lock your bike";
        }
        public string Unlock()
        {
            return "You unlock your bike";
        }
    }
}
