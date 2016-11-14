using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApp
{
    public class Electronics : Product
    {
        public string Color { get; set; }

        public override string PrintProductCustomer()
        {
            return String.Format("{0} Size: {1}.",
                                 base.PrintProductCustomer(),
                                 Color);
        }

        public override string PrintProductAdmin()
        {
            return String.Format("0} Size: {1}.",
                                 base.PrintProductAdmin(),
                                 Color);
        }
    }
}