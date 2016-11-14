using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    interface ISellable
    {
        string Brand { get; set; }
        string ProductType { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }

    }
}
