using System;
using System.Windows.Forms;

namespace Enumerationen
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogResult result;
            do
            {
                result = MessageBox.Show(
                    "Ein unerwarteter Fehler ist aufgetreten.",
                    "Fehler!",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                    Console.WriteLine("Auf ein Neues!");
            }
            while (result != DialogResult.Cancel);
        }

        private static Wochentage GetRandomDay()
        {
            return Wochentage.Mittwoch | Wochentage.Freitag | Wochentage.Donnerstag;
        }
    }
}
