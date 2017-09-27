using System;

namespace AbstrakteKlassen
{
    public abstract class Grafik        // in VB: abstract = mustinherit
    {
        public ConsoleColor Farbe { get; set; }
        public double Breite { get; set; }
        public double Höhe { get; set; }

        public Grafik(ConsoleColor farbe)
        {
            Farbe = farbe;
        }

        public abstract void Zeichnen();        // inVB: abstract = mustoverride

        public void Rendern()
        {
            // die Logik fürs Rendern
        }
    }
}
