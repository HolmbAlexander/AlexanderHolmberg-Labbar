using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11
{
    public delegate void AnalyzeNumber();

    class Runtime
    {
        private event AnalyzeNumber NumberInput;
        int input;
        public void Start()
        {
            Console.Clear();
            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDividableByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);

            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            OnNumberInput();
            Console.ReadKey(true);
        }

        #region Methods
        private void OnNumberInput()
        {
            NumberInput.Invoke();
        }

        private void IsEven()
        {
            if (input % 2 == 0)
            {
                Console.WriteLine("\nThe number is even.");
            }
            else
                Console.WriteLine("\nThe number is not even");
        }

        private void IsDividableByThree()
        {
            if (input % 3 == 0)
            {
                Console.WriteLine("\nThe number is dividable by three.");
            }
            else
                Console.WriteLine("\nThe number is not dividable by three.");
        }

        private void IsPrimeNumber()
        {
            bool isPrime = true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("\nThe number is Prime.");
            else
                Console.WriteLine("\nThe number is not prime.");
        }
        #endregion
    }
}
