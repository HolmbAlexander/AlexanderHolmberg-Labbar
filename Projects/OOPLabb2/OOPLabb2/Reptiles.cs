using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Reptiles : Animals
    {
        public string ShreddsSkin { get; set; }
        public string Reproduce { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Shreeds skin: {1}, Reproduce how: {2}, ",
                                 base.BasicInfo(),
                                 ShreddsSkin,
                                 Reproduce);
        }
    }
}