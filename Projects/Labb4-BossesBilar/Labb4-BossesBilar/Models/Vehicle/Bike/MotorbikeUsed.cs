using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4_BossesBilar
{
    public class MotorbikeUsed : Vehicle
    {
        public int Owners { get; set; }
        public int Mileage { get; set; }

        public override string BasicInfo()
        {
            return String.Format("{0} | Owners: {1}. | Mileage: {2}",
                                 base.BasicInfo(),
                                 Owners,
                                 Mileage);
        }
    }
}