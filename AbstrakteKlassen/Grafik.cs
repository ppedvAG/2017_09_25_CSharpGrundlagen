using System;

namespace AbstrakteKlassen
{
    public abstract class Grafik
    {
        public ConsoleColor Farbe { get; set; }
        public double Breite { get; set; }
        public double Höhe { get; set; }

        public Grafik(ConsoleColor farbe)
        {
            Farbe = farbe;
        }

        public abstract void Zeichnen();


    }
}
