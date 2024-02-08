﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_budynkiem
{
    internal class SystemOswietlenia
    {
        public bool swiatlaWlaczone { get; private set; }

        public SystemOswietlenia()
        {
            swiatlaWlaczone = true;
        }

        public void PrzelaczSwiatla()
        {
            swiatlaWlaczone = !swiatlaWlaczone;
            Console.WriteLine(swiatlaWlaczone ? "Światła zostały włączone." : "Światła zostały wyłączone.");

        }

        public bool StanSwiatel()
        {
            return swiatlaWlaczone;
        }
    }
}
