using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Snakes : Reptiles
    {
        public string Venomous { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Venomous: {1}.",
                                 base.BasicInfo(),
                                 Venomous);
        }
    }
}