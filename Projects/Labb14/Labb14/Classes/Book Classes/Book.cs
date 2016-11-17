using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Book : Publication
    {
        public enum Genre
        {
            Horror,
            Romance,
            Comedy,
            Fantasy
        }
        public int Pages { get; set; }
    }
}
