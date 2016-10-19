using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public class Filmer : Evangemang
    {
        public string Genre { get; set; }
        public string SittPlats { get; set; }

        public override string Bokning()
        {
            return String.Format("{0} Genre: {1}. Plats: {2}. ",
                                 base.Bokning(),
                                 Genre,
                                 SittPlats);
        }

        public override string BokningNamn()
        {
            return String.Format("{0} Genre: {1}. Plats: {2}. ",
                                 base.BokningNamn(),
                                 Genre,
                                 SittPlats);
        }
    }
}