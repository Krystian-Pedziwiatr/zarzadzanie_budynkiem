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
                int liczbaKropek = 3;
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

            while (programDziala)
            {
                Console.WriteLine("\nMenu systemu:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Informacje o budynku");
                Console.WriteLine("2. Zdalne zarządzanie");
                Console.WriteLine("3. Automatyzacja");
                Console.WriteLine("4. Raport ogólny");
                Console.WriteLine("5. Wyjście");
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


                        break;

                    case "3":


                        break;

                    case "4":
                        Console.Clear();

                        break;

                    case "5":
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
        else
        {
            Console.WriteLine("Podano złe dane logowania spróbuj jeszcze raz!");
            
        }

        }
    }

