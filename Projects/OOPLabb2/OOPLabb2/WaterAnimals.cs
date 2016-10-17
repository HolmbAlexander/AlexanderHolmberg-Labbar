using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class WaterAnimals : Animals
    {
        public string Reproduce { get; set; }
        public string Watertype { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Reproduce by: {1}, Saltwater or freshwater: {2},",
                                 base.BasicInfo(),
                                 Reproduce,
                                 Watertype);
        }

    }
}