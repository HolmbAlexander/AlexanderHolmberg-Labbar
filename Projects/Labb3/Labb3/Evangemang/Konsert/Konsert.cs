using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public class Konserter : Evangemang
    {
        public string Sittplats { get; set; }
        public string FörBand { get; set; }

        public override string Bokning()
        {
            return String.Format("{0}Sittplats kvar: {1}. Förband: {2}. ",
                                 base.Bokning(),
                                 Sittplats,
                                 FörBand);
        }

        public override string BokningNamn()
        {
            return String.Format("{0}Sittplats kvar: {1}. Förband: {2}. ",
                                 base.BokningNamn(),
                                 Sittplats,
                                 FörBand);
        }
    }
}