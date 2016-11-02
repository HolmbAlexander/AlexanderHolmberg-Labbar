using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4_BossesBilar
{
    public class MotorbikeNew : Vehicle
    {
        public int FreeScervice { get; set; }
        public string Color { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} | Free service years: {1}. | Color: {2}. ",
                                 base.BasicInfo(),
                                 FreeScervice,
                                 Color);
        }
    }
}