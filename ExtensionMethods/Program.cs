using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hallo Welt";

            //Console.WriteLine(StringExtensions.Reverse(text));
            Console.WriteLine(text.Reverse());
            Console.WriteLine("O Genie, der Herr ehre dein Ego!".Reverse());
            Console.ReadLine();
        }
    }

    public static class StringExtensions
    {
        public static string Reverse(this string value)
        {
            string reverse = string.Empty;

            for (int i = value.Length - 1; i >= 0; i--)
                reverse += value[i];

            return reverse;
        }
    }
}
