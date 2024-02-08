using System;
namespace zarzadzanie_budynkiem
{
    public class Zdalne_zarzadzanie: Budynek
    {
        private Budynek budynek;

        public Zdalne_zarzadzanie(Budynek budynek)
        {

            this.budynek = budynek;
        }

        public Zdalne_zarzadzanie()
        {
        }

        public void WyswietlMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Włącz/wyłącz światło w salonie");
            Console.WriteLine("2. Włącz/wyłącz światło w pokoju");
            Console.WriteLine("3. Włącz/wyłącz światło w kuchni");
            Console.WriteLine("4. Otwórz/zamknij okna w salonie");
            Console.WriteLine("5. Otwórz/zamknij okna w kuchni");
            Console.WriteLine("6. Wyjście");
        }

        private SystemOswietlenia Oswietlenie;

        public void ObsluzWybor()
        {
            bool programDziala = true;

            while (programDziala)
            {
                WyswietlMenu();
                Console.Write("Wybierz opcję: ");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":

                        Oswietlenie.PrzelaczSwiatla();
                        
                        
                        break;
                    case "2":
                        Console.WriteLine("Wybrano opcję 2.");
                        // Tutaj dodaj logikę dla opcji 2
                        break;
                    case "3":
                        programDziala = false;
                        Console.WriteLine("Zamykanie menu...");

                        Console.Clear();
                        break;

                    case "4":

                       
                       
                       
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }
            }

        }
    }
}

