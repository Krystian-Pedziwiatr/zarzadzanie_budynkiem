using System;
namespace zarzadzanie_budynkiem
{
    public SystemOswietlenia Oswietlenie { get; set; }
    public SystemBezpieczenstwa Bezpieczenstwo { get; set; }
    public ZarzadzanieEnergia SystemEnergi { get; set; }
    public SystemKamer HVAC { get; set; }

    public class Budynek
    {

        private BazaDanych bazaDanych;




        public Budynek()
        {
            bazaDanych = new BazaDanych();
            Oswietlenie = new SystemOswietlenia();
            Bezpieczenstwo = new SystemBezpieczenstwa();
            SystemEnergi = new ZarzadzanieEnergia();
        }

        public void Wyswietldane()
        {

            var informacje = bazaDanych.OdczytajPlik("informacje.txt");
            foreach (var dom in informacje)
            {
                Console.WriteLine($"ID: {dom[0]}");
                Console.WriteLine($"Adres twojego budynku: {dom[1]}");
                Console.WriteLine($"Powierzchnia budynku: {dom[2]}");

            }


        }
    }
}


