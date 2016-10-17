using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Ants : Insects
    {
        public double Lift { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} How many times can it lift it´s own weghit: {1}.",
                                 base.BasicInfo(),
                                 Lift);
        }
    }
}