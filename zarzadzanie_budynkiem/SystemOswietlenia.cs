using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_budynkiem
{
    public class SystemOswietlenia
    {
        public bool swiatlaWlaczone { get; set; }

        public SystemOswietlenia()
        {
            swiatlaWlaczone = false;
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
