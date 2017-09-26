using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fahrzeug();
            var k = new Kreis();

            Lackieren(f);
            Lackieren(k);
            GibtMirEineKopie(f);
        }

        private static void Lackieren(ILackierbar l)
        {
            l.Farbe = "neue Farbe vom Lackieren: Blau";
        }

        private static void GibtMirEineKopie(ICloneable obj)
        {
            var kopie = obj.Clone();
        }
    }
}
