namespace StatischeMemberUndKlassen
{
    // NICHT Statische Klassen können statische und nicht statische Member beinhalten.
    // Statische Klassen können nur statisch Member beinhalten.

    internal static class Rechner
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
