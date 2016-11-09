using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class MyClass
    {
        public string[] MyArray { get; set; }
        public float[] MyFloat { get; set; }

        public MyClass()
        {
            MyArray = new string[]
            {
                "String 1",
                "String 2",
                "String 3",
                "String 4",
                "String 5"
            };

            MyFloat = new float[]
            {
                12,
                23,
                34
            };
        }       
    }
}
