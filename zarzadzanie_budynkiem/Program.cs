using System;
using System.Security.Cryptography.X509Certificates;
using zarzadzanie_budynkiem;

class Program
{
    static void Main(string[] args)
    {

        var bazaDanychUzytkownikow = new BazaDanychUzytkownikow("uzytkownicy.txt");
        var uzytkownicy = bazaDanychUzytkownikow.OdczytajUzytkownikow();

        var logowanie = new Logowanie(uzytkownicy);
        bool zalogowany = logowanie.Zaloguj();

        if (zalogowany)
        {




            Console.WriteLine("\n * Witaj w systemie zarządzania budynkiem *");


            PokazAnimacjeLadowania(2000);

            static void PokazAnimacjeLadowania(int czasTrwania)
            {
                Console.Write("\n Ładowanie");
                int liczbaKropek = 2;
                int czasNaKropke = czasTrwania / liczbaKropek;

                for (int i = 0; i < liczbaKropek; i++)
                {
                    Thread.Sleep(czasNaKropke); // Czekaj określony czas przed dodaniem kolejnej kropki
                    Console.Write(".");
                }
                Console.Clear();
            }

            bool programDziala = true;

            Budynek budynek = new Budynek();

            SystemOswietlenia OswietleniePokoju = new SystemOswietlenia();
            SystemOswietlenia OswietlenieSalonu = new SystemOswietlenia();
            SystemOswietlenia OswietlenieKuchni = new SystemOswietlenia();
            SystemOtwierania OknaWSalonie = new SystemOtwierania();
            SystemOtwierania OknaWKuchni = new SystemOtwierania();
            Automatyzacja automatyzacja = new Automatyzacja();
            PolaczenieZsystemami polaczenie = new PolaczenieZsystemami();

            while (programDziala)
            {
                Console.WriteLine("\nMenu systemu:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Informacje o budynku");
                Console.WriteLine("\n");
                Console.WriteLine("-- Zdalne zarządzanie --");
                Console.WriteLine("2. Włącz/wyłącz światło w pokoju");
                Console.WriteLine("3. Włącz/wyłącz światło w salonie");
                Console.WriteLine("4. Włącz/wyłącz światło w kuchni");
                Console.WriteLine("5. Otwórz/zamknij okna w salonie");
                Console.WriteLine("6. Otwórz/zamknij okna w kuchni");
                Console.WriteLine("\n");
                Console.WriteLine("-- Automatyzacja --");
                Console.WriteLine("7. Ustaw temperature w pomieszczeniach");
                Console.WriteLine("8. Ustaw godziny włączenia świateł w ogrodzie");
                Console.WriteLine("\n");
                Console.WriteLine("-- Raporty --");
                Console.WriteLine("9. Zużycie prądu");
                Console.WriteLine("10.Zużycie wody");
                Console.WriteLine("\n");
                Console.WriteLine("___________________");
                Console.WriteLine("11.Połącznie z zewnętrznymi systemami");
                Console.WriteLine("\n");
                Console.WriteLine("12. Wyjście");
                Console.WriteLine("___________________");

                Console.Write("Wybierz odpowiednią opcję: ");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Dane twojego budynku");
                        budynek.Wyswietldane();
                        break;

                    case "2":
                        Console.Clear();

                        OswietleniePokoju.PrzelaczSwiatla();
                        
                        break;

                    case "3":
                        Console.Clear();
                        OswietlenieSalonu.PrzelaczSwiatla();
                        break;

                    case "4":
                        Console.Clear();
                        OswietlenieKuchni.PrzelaczSwiatla();
                        break;

                    case "5":
                        Console.Clear();

                        OknaWSalonie.OtworzOkna();

                        break;

                    case "6":
                        Console.Clear();
                        OknaWKuchni.OtworzOkna();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Wprowadź temperaturę w formacie 00.0:");
                        string wprowadzonaTemperatura = Console.ReadLine();
                        double temperatura = double.Parse(wprowadzonaTemperatura);
                        Console.Clear();
                        automatyzacja.UstawTemperature(temperatura);
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Wprowadź godzinę w formacie 00:00:");
                        string wprowadzonaGodzina = Console.ReadLine();
                        Console.Clear();
                        automatyzacja.UstawGodzineWlaczeniaSwiatel(wprowadzonaGodzina);

                        break;

                    case "9":
                        Console.Clear();
                        budynek.ZuzycieEnergii_wyswietl();
                        break;

                    case "10":
                        Console.Clear();
                        budynek.ZuzycieWody_wyswietl();
                        
                        break;

                    case "11":
                        Console.Clear();
                        polaczenie.WyswietlPolacznia();
                        break;

                    case "12":
                        programDziala = false;
                        Console.Clear();
                        Console.WriteLine("Zamykanie programu...");
                        PokazAnimacjeLadowania(2000);
                        break;

                    default:

                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }

            }
        }

    }
}

