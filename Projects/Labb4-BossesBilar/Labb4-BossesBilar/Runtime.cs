﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_BossesBilar
{
    class Runtime
    {
        Menus menus = new Menus();
        public void Start()
        {
            menus.WelcomeMenu();
        }
    }
}