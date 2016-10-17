using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Parrots : Birds
    {
        public string Talk { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Can it talk: {1}",
                                 base.BasicInfo(),
                                 Talk);
        }
    }
}