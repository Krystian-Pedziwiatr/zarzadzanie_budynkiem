using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_budynkiem
{
    public class SystemOtwierania
    {
        public bool Oknaotwarte { get; set; }

        public SystemOtwierania()
        {
            Oknaotwarte = false;
        }

        public void OtworzOkna()
        {
            Oknaotwarte = !Oknaotwarte;
            Console.WriteLine(Oknaotwarte ? "Okna zostały otwarte." : "Okna zostały zamknięte.");

        }

        public bool StanOkien()
        {
            return Oknaotwarte;
        }
    }


}
