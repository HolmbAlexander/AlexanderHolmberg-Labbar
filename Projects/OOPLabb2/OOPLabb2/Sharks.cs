using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public class Sharks : WaterAnimals
    {
        public string Breed { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} Breeds by: {1}",
                                 base.BasicInfo(),
                                 Breed);
        }
    }
}