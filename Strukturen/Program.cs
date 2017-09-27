namespace Strukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fahrzeug(50);
            
            var pkw = f;        // bei strukturen eine echte Kopie -> Werttypen!!
          

            // Objekte von Strukturen werden am Stack gespeichert
            // Objeket von Klassen am Heap

            // Bei Strukturen gibts keine Vererbung
        }
    }
}
