using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class ProductManager
    {
        public List<Product> productList = new List<Product>()
        {
            new Product { Id = 1, Name = "Samsung",     Price = 5995.95f },
            new Product { Id = 2, Name = "Philips",     Price = 4495.50f },
            new Product { Id = 3, Name = "Toothbrush",  Price = 10.50f },
            new Product { Id = 4, Name = "Toshiba",     Price = 3795.80f }
        };

        public string FormatProductInfo(Runtime.StringConcatinator productNames)
        {
            string output = "";
            foreach (var product in productList)
            {
                output += product.Id + ": " + product.Name + ". Price: " + product.Price +".\n";
            }
            return output;
        }

        public float PriceOperatorAdd(Runtime.NumberOperator productPrice)
        {
            float output = 0;
            foreach (var price in productList)
            {
                    output += price.Price;
            }
            output = output * 1.2f;
            return output;
        }

        public float PriceOperatorAddOver1000(Runtime.NumberOperator productPrice)
        {
            float output = 0;
            foreach (var price in productList)
            {
                if (price.Price > 1000)
                {
                    output += price.Price;
                }
            }
            output -= output * 0.1f;
            return output;
        }
    }
}
