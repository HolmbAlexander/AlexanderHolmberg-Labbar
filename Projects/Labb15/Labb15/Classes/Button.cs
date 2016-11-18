using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Button : IPushable
    {
        public string Push()
        {
            return "Everything explodes...";
        }
    }
}
