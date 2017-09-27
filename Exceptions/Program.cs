using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zahl1 = int.Parse(Console.ReadLine());
                int zahl2 = int.Parse(Console.ReadLine());

                var today = DateTime.Now.Day;
                if (zahl1 == today || zahl2 == today)
                    throw new MustNotBeTodayException(today, "Heute ist bei mir ganz schlecht. Probiers mal morgen.");

                int ergebnis = checked(zahl1 + zahl2);

                Console.WriteLine(ergebnis);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("So nicht!");
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Bitte kleinere Zahlen eingeben.");
            }
            catch(MustNotBeTodayException ex) when (ex.ForbiddenNumber > 10)
            {
                Console.WriteLine($"Gößer 10");
                Console.WriteLine($"Die verbotene Zahl: {ex.ForbiddenNumber}");
                Console.WriteLine(ex.Message);
            }
            catch (MustNotBeTodayException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                // todo
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt!");
            }

            Console.ReadLine();
        }
    }
}
