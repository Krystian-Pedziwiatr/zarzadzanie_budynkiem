using System;
namespace zarzadzanie_budynkiem
{
	public class BazaDanychUzytkownikow
	{
        private string sciezkaDoPliku;

        public BazaDanychUzytkownikow(string sciezka)
        {
            sciezkaDoPliku = sciezka;
        }

        public Dictionary<string, string> OdczytajUzytkownikow()
        {
            var uzytkownicy = new Dictionary<string, string>();

            if (!File.Exists(sciezkaDoPliku))
            {
                Console.WriteLine("Plik z użytkownikami nie istnieje.");
                return uzytkownicy;
            }

            var linie = File.ReadAllLines(sciezkaDoPliku);
            foreach (var linia in linie)
            {
                var dane = linia.Split(',');
                if (dane.Length == 2)
                {
                    uzytkownicy[dane[0]] = dane[1];
                }
            }

            return uzytkownicy;
        }
    }
}

