using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApp
{
    public class Product : ISellable
    {
        public string Brand { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual string PrintProductCustomer()
        {
            return String.Format("Product: {0}. Brand: {1}. Price: {2}.",
                                 ProductType,
                                 Brand,
                                 Price);
        }

        public virtual string PrintProductAdmin()
        {
            return String.Format("Product: {0}. Brand: {1}. Price: {2}. Quantity: {3}.",
                                 ProductType,
                                 Brand,
                                 Price,
                                 Quantity);
        }
    }
}