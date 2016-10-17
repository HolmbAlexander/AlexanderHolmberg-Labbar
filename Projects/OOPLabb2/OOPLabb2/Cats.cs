using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
   
    public class Cats : LandAnimals
    {
            public string Clean { get; set; }

            public override string BasicInfo()
            {
                return String.Format("{0} Cleans itself by: {1}.",
                                     base.BasicInfo(),
                                     Clean);
        }
    }
}
