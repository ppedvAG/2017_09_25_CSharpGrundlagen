using System;

namespace MethodenUndParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Addieren(8, 6));
            //Console.WriteLine(Addieren(8, 6));
            //Console.WriteLine(Addieren(8, 6));

            // Parameter bennenen
            Addieren(zahl1: 20, zahl2: 30);
            Addieren(zahl2: 30, zahl1: 10);
            Addieren(5, zahl2: 90);
            Addieren(zahl1: 5, zahl2: 90);

            // Optionale Parameter
            OptionaleParameter(5, "Mein Text", 5.2);
            OptionaleParameter(5, "Mein Text");
            OptionaleParameter(23);
            OptionaleParameter(2, wert: 9.6);

            // Referenz Parameter
            int zahl = 5;
            RefrenzParamter(ref zahl);
            Console.WriteLine(zahl);

            int andereZahl;
            var x = OutParameter(out zahl, out andereZahl);
            Console.WriteLine(zahl);
            
        }

        private static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        private static void OptionaleParameter(int zahl, string text = "", double wert = 2.3)
        { }

        private static void RefrenzParamter(ref int z)
        {
            z += 100;
        }

        private static Tuple<int, string, double> OutParameter(out int zahl, out int zahl1)
        {
            zahl = 5689;
            zahl1 = 5689;
            return new Tuple<int, string, double>(7, "Hallo", 9.8);
        }
    }
}
