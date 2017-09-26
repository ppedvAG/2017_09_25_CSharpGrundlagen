using System;

namespace AbstrakteKlassen
{
    public class Kreis : Grafik
    {
        public Kreis(ConsoleColor farbe) : base(farbe)
        { }

        public override void Zeichnen()
        {
            var tempColor = Console.ForegroundColor;
            Console.ForegroundColor = Farbe;
            Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe}.");
            Console.ForegroundColor = tempColor;
        }
    }
}
