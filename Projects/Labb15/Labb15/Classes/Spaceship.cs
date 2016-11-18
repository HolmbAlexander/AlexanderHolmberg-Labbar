using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Spaceship : IVehicle
    {
        public string Start()
        {
            return "Spaceship is ready to launch...";
        }
        public string Stop()
        {
            return "Spaceship crashes in ocean";
        }
        public string Lock()
        {
            return "Cant enter spaceship now";
        }
        public string Unlock()
        {
            return "Can enter spaceship now";
        }
    }
}
