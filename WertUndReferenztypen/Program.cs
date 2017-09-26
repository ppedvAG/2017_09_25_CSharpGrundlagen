using System;

namespace WertUndReferenztypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objekte von Klassen sind immer Referenztypen
            // Objekte von Strukturen sind immer Werttypen
            // Ausnahme: class String -> hat das Verhalten eines Werttypes
            
            Console.WriteLine("------ Wert Typen ------");

            int i = 5;
            int j = i;

            Console.WriteLine($"I: {i}");
            Console.WriteLine($"J: {j}");

            j = 100;

            Console.WriteLine("\nJ ändern");
            Console.WriteLine($"I: {i}");
            Console.WriteLine($"J: {j}");


            Console.WriteLine("\n\n\n");



            Console.WriteLine("------ Refrenz Typen ------");

            Fahrzeug pkw = new Fahrzeug();
            pkw.Geschwindigkeit = 50;
            Fahrzeug lkw = pkw;
            //Fahrzeug lkw = new Fahrzeug();
            //lkw.Geschwindigkeit = pkw.Geschwindigkeit;

            Console.WriteLine($"Pkw: {pkw.Geschwindigkeit}");
            Console.WriteLine($"Lkw: {lkw.Geschwindigkeit}");

            lkw.Geschwindigkeit = 120;

            Console.WriteLine("\nLkw beschleunigen");
            Console.WriteLine($"Pkw: {pkw.Geschwindigkeit}");
            Console.WriteLine($"Lkw: {lkw.Geschwindigkeit}");

            Console.ReadKey();
        }
    }
}
