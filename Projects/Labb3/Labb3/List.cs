using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class List
    {
        public List<Konserter> konserterList = new List<Konserter>
        { new Konserter { NamnEvangemang = "Fallout Boy", FörBand = "Aqua", Sittplats = "Nej", Pris = 699, Stad = "Stockholm" } };
        public List<Filmer> filmerList = new List<Filmer>();
        public List<Festivaler> festivalerList = new List<Festivaler>();
    }
}
