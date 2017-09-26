using System;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug pkw = new Fahrzeug();
            pkw.Geschwindigkeit = 50;
            pkw.Beschleunigen(100);
            pkw.Beschleunigen(1.5);
            pkw.Farbe = "Blau";
            pkw.Baujahr = 2004;

            Fahrzeug bus = new Fahrzeug();
            bus.Geschwindigkeit = int.MaxValue;
            bus.Bremsen(120);
            bus.Farbe = "Blau";
            pkw.Baujahr = 2016;

            Console.WriteLine(pkw.Geschwindigkeit);
            Console.WriteLine(bus.Geschwindigkeit);

            Console.ReadKey();
        }
    }
}
