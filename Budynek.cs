using System;
namespace zarzadzanie_budynkiem
{
   

    public class Budynek
    {

        private BazaDanych bazaDanych;
        



      

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


