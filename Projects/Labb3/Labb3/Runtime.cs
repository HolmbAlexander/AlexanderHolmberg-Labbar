using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Runtime
    {
        //List<Konserter> konserterList = new List<Konserter>();
        //List<Filmer> filmerList = new List<Filmer>();
        //List<Festivaler> festivalerList = new List<Festivaler>();
        Menus menus = new Menus();
        public void Start()
        {
            menus.VälkomstMeny();
        }
    }
}
