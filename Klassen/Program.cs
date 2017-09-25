using System;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug pkw = new Fahrzeug();
            pkw.Geschwindigkeit = 50;
            pkw.Farbe = "Blau";

            Fahrzeug bus = new Fahrzeug();
            bus.Geschwindigkeit = int.MaxValue;
            bus.Farbe = "Blau";

            Console.WriteLine(bus.Geschwindigkeit);

            Console.ReadKey();
        }
    }
}
