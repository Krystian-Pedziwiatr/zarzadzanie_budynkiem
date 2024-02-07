using System;
namespace zarzadzanie_budynkiem
{
	public class Logowanie
	{
        private Dictionary<string, string> uzytkownicy;

        public Logowanie(Dictionary<string, string> uzytkownicy)
        {
            this.uzytkownicy = uzytkownicy;
        }

        public bool Zaloguj()
        {
            Console.Write("Nazwa użytkownika: ");
            string nazwaUzytkownika = Console.ReadLine();

            Console.Write("Hasło: ");
            string haslo = Console.ReadLine();

            if (uzytkownicy.TryGetValue(nazwaUzytkownika, out string zapisaneHaslo) && zapisaneHaslo == haslo)
            {
                Console.WriteLine("Logowanie pomyślne.");
                return true;
            }
            else
            {
                Console.WriteLine("Błędna nazwa użytkownika lub hasło.");
                return false;
            }
        }
    }
}

