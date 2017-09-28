using System;

using static System.Console;
//using static StatischeMemberUndKlassen.Rechner;

namespace StatischeMemberUndKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Rechner();
            //var sub = r.Sub(9, 20);

            var ergebnis = Rechner.Add(5, 9);

            WriteLine();    // möglich wegen using static System.Console;
        }
    }
}
