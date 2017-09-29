using System;
using System.Collections.Generic;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fahrzeug("Blau");

            var f2 = new Fahrzeug("Rot", 50);

            var pkw = new Pkw("Blau");
            pkw.Sitzplätze = 5;
            pkw.Geschwindigkeit = 20;
            pkw.Farbe = "Blau";
            pkw.Beschleunigen(10);
            pkw.Bremsen(30);

            var lkw = new Lkw("Rot");
            lkw.MaxLadung = 18000;
            lkw.Geschwindigkeit = 80;
            lkw.Farbe = "Rot";
            lkw.Beschleunigen(20);
            lkw.Bremsen(50);

            var c = new Cabrio("Rosa");

            Lackieren(f);
            Lackieren(pkw);
            Lackieren(lkw);
            Lackieren(c);
            Console.WriteLine(f.Farbe);

            var fahrzeuge = new List<Fahrzeug>();
            fahrzeuge.Add(f);
            fahrzeuge.Add(pkw);
            fahrzeuge.Add(lkw);
            fahrzeuge.Add(c);

            foreach (var fahrzeug in fahrzeuge)
            {
                Console.WriteLine(fahrzeug.Farbe);
            }

            Console.ReadKey();
        }

        private static void Lackieren(Fahrzeug f)
        {
            f.Farbe = "Lila";
        }
    }
}
