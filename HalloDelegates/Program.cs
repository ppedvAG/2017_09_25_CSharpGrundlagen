using System;

namespace HalloDelegates
{
    public delegate string MyDelegate(int zahl, double wert);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(MeineMethode);

            var result = del.Invoke(8, 9.3);
            System.Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string MeineMethode(int i, double d)
        {
            return (i + d).ToString();
        }
    }
}
