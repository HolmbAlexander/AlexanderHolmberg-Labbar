using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApp
{
    public class Clothes : Product
    {
        public string Size { get; set; }

        public override string PrintProductCustomer()
        {
            return String.Format("{0} Size: {1}.",
                                 base.PrintProductCustomer(),
                                 Size);
        }

        public override string PrintProductAdmin()
        {
            return String.Format("{0} Size: {1}.",
                                 base.PrintProductAdmin(),
                                 Size);
        }
    }
}