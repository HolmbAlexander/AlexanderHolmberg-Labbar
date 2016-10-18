using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public class Festivaler : Evangemang
    {
        public string FestivalGenre { get; set; }
        public int AntalDagar { get; set; }

        public override string Bokning()
        {
            return String.Format("{0} Genre: {1}. Dagar: {2}. ",
                                 base.Bokning(),
                                 FestivalGenre,
                                 AntalDagar);
        }
    }
}