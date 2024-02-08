using System;
namespace zarzadzanie_budynkiem
{
	public class Automatyzacja: Budynek
	{
		SystemOswietlenia Oswietlenie = new SystemOswietlenia();

		public Automatyzacja() : base()
		{

		}

		public void UstawTemperature(double nowaTemperatura)
		{
			Temperatura = nowaTemperatura;
			Console.WriteLine($"Temperatura w budynku została zmieniona na {Temperatura} stopni Celcjusza.");
		}

        public void UstawGodzineWlaczeniaSwiatel(string nowaGodzina)
        {
            GodzinaWlaczeniaSwiatel = nowaGodzina;

            Console.WriteLine($"Godzina włączenia świateł w ogrodzie została zmieniona na {GodzinaWlaczeniaSwiatel}.");
			Oswietlenie.PrzelaczSwiatla();
        }

        public void PokazTemporature()
		{
			Console.WriteLine($"Aktualna Temperatura w budynku: {Temperatura} stopni Celcjusza.");
		}
	}
}

