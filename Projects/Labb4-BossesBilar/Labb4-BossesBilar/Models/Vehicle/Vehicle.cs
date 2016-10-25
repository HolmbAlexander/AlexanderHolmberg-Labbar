using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4_BossesBilar
{
    public class Vehicle
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        public int Amount { get; set; }

        public virtual string BasicInfo()
        {
            return String.Format("Maker: {0}. | Model: {1}. | Price: {2}. | Amount: {3}.",
                                 Maker,
                                 Model,
                                 Price,
                                 Amount);
        }

    }
}