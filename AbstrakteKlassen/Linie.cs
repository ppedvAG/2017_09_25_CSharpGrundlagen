using System;

namespace AbstrakteKlassen
{
    public class Linie : Grafik
    {
        public Linie(ConsoleColor farbe) : base(farbe)
        { }

        public override void Zeichnen()
        {
            Console.WriteLine($"Zeichne Linie in der Farbe {Farbe}.");
        }
    }
}
