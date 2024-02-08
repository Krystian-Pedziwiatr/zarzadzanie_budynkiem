using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;

namespace zarzadzanie_budynkiem
{
	public class BazaDanych
	{
   
        
            private string sciezkaInformacje = "informacje.txt";
            private string sciezkaPokoje = "pokoje.txt";
            private string sciezkaUzytkownicy = "uzytkownicy.txt";

            // Odczyt danych z pliku
            public List<string[]> OdczytajPlik(string sciezka)
            {
                var dane = new List<string[]>();
                var linie = File.ReadAllLines(sciezka);

                foreach (var linia in linie.Skip(1)) // Pomija nagłówek
                {
                    var pola = linia.Split(',');
                    dane.Add(pola);
                }

                return dane;
            }

            // Zapis danych do pliku
            public void ZapiszDoPliku(string sciezka, List<string[]> dane)
            {
                using (var sw = new StreamWriter(sciezka, false))
                {
                    foreach (var wpis in dane)
                    {
                        sw.WriteLine(string.Join(",", wpis));
                    }
                }
            }

            // Dodawanie nowego wpisu
            public void DodajWpis(string sciezka, string[] wpis)
            {
                using (var sw = File.AppendText(sciezka))
                {
                    sw.WriteLine(string.Join(",", wpis));
                }
            }

            // Usuwanie wpisu
            public void UsunWpis(string sciezka, int id)
            {
                var dane = OdczytajPlik(sciezka);
                dane.RemoveAll(w => int.Parse(w[0]) == id);
                ZapiszDoPliku(sciezka, dane);
            }

            // Aktualizacja wpisu
            public void AktualizujWpis(string sciezka, int id, string[] nowyWpis)
            {
                var dane = OdczytajPlik(sciezka);
                var indeks = dane.FindIndex(w => int.Parse(w[0]) == id);
                if (indeks != -1)
                {
                    dane[indeks] = nowyWpis;
                    ZapiszDoPliku(sciezka, dane);
                }
            }

            // Metody specyficzne dla poszczególnych typów danych, np. dla mieszkań, pokoi, użytkowników
            // Można tu dodać metody jak OdczytajMieszkania(), ZapiszMieszkania(), itp.
        }
 }




