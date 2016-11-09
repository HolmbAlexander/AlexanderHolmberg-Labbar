using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Runtime
    {
        public delegate string StringConcatinator(string[] delegateString);
        public string DelegateString(string[] delegateString)
        {
            string output = "";
            foreach (var word in delegateString)
            {
                output += word + ", ";
            }
            return output;
        }

        public delegate float NumberOperator(float[] delegateFloat);
        public float DelegateFloatAdd(float[] delegateFloat)
        {
            float output = 0;
            foreach (var number in delegateFloat)
            {
                output += number;
            }
            return output;
        }

        public float DelegateFloatMultiplication(float[] delegateFloatMultiplication)
        {
            float output = 1;
            foreach (var number in delegateFloatMultiplication)
            {
                output *= number;
            }
            return output;
        }

        public void Start()
        {
            //MyClass myClass = new MyClass();
            //StringConcatinator del1 = DelegateString;
            //Console.WriteLine(del1(myClass.MyArray));

            //NumberOperator del2 = DelegateFloatAdd;
            //Console.WriteLine("Summary: " + del2(myClass.MyFloat));

            //NumberOperator del3 = DelegateFloatMultiplication;
            //Console.WriteLine("Product: " + del3(myClass.MyFloat));



            // VG del
            Menus menus = new Menus();
            menus.MainMenu();

        }

        public void ShowItems()
        {
            Console.Clear();
            ProductManager myProduct = new ProductManager();
            StringConcatinator del4 = DelegateString;
            Console.WriteLine(myProduct.FormatProductInfo(del4));
        }

        public void ShoppingCartAdd()
        {
            Console.Clear();
            ProductManager myProduct = new ProductManager();
            NumberOperator del5 = DelegateFloatAdd;
            Console.WriteLine("Total price when added: " + myProduct.PriceOperatorAdd(del5));

            NumberOperator del6 = DelegateFloatAdd;
            Console.WriteLine("All prices over 1000 with -10% off: " + myProduct.PriceOperatorAddOver1000(del6));
        }

    }
}
