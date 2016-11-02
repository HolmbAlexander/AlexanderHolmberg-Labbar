using Console_Adventure.DataStores.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.Classes
{
    class Room : IEnviroment
    {
        public string Enviroment { get; set; }
        public string Size { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }

        public string ObservEnviorment()
        {
            return "It´s a " + Size + " room. " + Enviroment;
        }

        public string Notebook()
        {
            return "It's your notebook... So far you have written down: \n" + Note1 + "\n" + Note2 + "\n" + Note3;
        }
    }
}
