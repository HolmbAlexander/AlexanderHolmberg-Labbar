using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Birds : Animals
    {
        public string Sing { get; set; }
        public string FlyingAbility { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Sings: {1}. Flying ability: {2}.\n",
                                 base.BasicInfo(),
                                 Sing,
                                 FlyingAbility);
        }
    }
}