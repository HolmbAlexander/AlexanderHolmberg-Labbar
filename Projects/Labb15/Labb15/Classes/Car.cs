using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Car : IVehicle
    {
        public string Start()
        {
            return "Car starts...";
        }
        public string Stop()
        {
            return "Car stops...";
        }
        public string Lock()
        {
            return "Car is locked now";
        }
        public string Unlock()
        {
            return "Car is unlocked now";
        }
    }
}
