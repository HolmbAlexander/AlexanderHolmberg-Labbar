using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class LandAnimals : Animals
    {
        public int NumberOfLegs { get; set; }
        public string Fur { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Number of legs: {1}, Fur: {2},",
                                 base.BasicInfo(),
                                 NumberOfLegs,
                                 Fur);
        }
    }
}