﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Boulder : IPushable
    {
        public string Push()
        {
            return "Boulder starts rolling...";
        }
    }
}
