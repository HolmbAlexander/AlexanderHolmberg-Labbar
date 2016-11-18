using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15
{
    interface IVehicle
    {
        string Start();
        string Stop();
        string Lock();
        string Unlock();
    }
}
