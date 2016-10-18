using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public class Evangemang
    {
        public string Namn { get; set; }
        public string NamnEvangemang { get; set; }
        public int Pris { get; set; }
        public string Stad { get; set; }

        public virtual string Bokning()
        {
            return String.Format("Namn: {0}. Evangemang: {1}. Pris: {2}. Plats: {3}. ",
                                 Namn,
                                 NamnEvangemang,
                                 Pris,
                                 Stad);
        }
    }
}