using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Insects : Animals
    {
        public int NumberOfLegs { get; set; }
        public string LivesInNest { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Number of legs: {1}, Lives in nest: {2},",
                                 base.BasicInfo(),
                                 NumberOfLegs,
                                 LivesInNest);
        }
    }
}