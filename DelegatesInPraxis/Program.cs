using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInPraxis
{
    internal delegate bool MyDelegate(Employee e);
    // Action       -> void
    // Predicate<T> -> bool
    // Func

    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetData();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            //var del = new Func<Employee, bool>(Bedingung);
            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate (Employee e)
            //{
            //    return e.Experience < 5;
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Experience < 5;
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Experience < 5 && e.Experience > 2;
            //});

            var query = Abfrage(employees, (e) => e.Experience < 5);

            var ext = employees.Abfrage(e => e.Experience > 5);
            var namen = new[] { "Hans", "Peter", "Sepp" };
            namen.Abfrage(n => n.Length > 4);

            var linqQuery = employees.Where(e => e.Experience > 5);

            foreach (var e in query)
                Console.WriteLine($"Id: {e.Id,2} | {e.Name,-10} | {e.Experience}");

            Console.ReadKey();
        }

        private static bool Bedingung(Employee e)
        {
            return e.Name.Length > 4;
        }

        private static IEnumerable<Employee> Abfrage(
            IEnumerable<Employee> employees,
            Func<Employee, bool> predicate)
        {
            var query = new List<Employee>();

            foreach (var e in employees)
                if (predicate(e))
                    query.Add(e);

            return query;
        }

        private static IEnumerable<Employee> GetData()
        {
            return new[]
            {
                new Employee { Id = 1, Name = "Sepp", Experience = 5},
                new Employee { Id = 2, Name = "Maria", Experience = 8},
                new Employee { Id = 3, Name = "Stanislaus", Experience = 3},
                new Employee { Id = 4, Name = "Lisa", Experience = 9},
                new Employee { Id = 5, Name = "Anna", Experience = 1},
                new Employee { Id = 6, Name = "Thomas", Experience = 6},
                new Employee { Id = 7, Name = "Hannes", Experience = 5},
                new Employee { Id = 8, Name = "Max", Experience = 8},
                new Employee { Id = 9, Name = "Luise", Experience = 2}
            };
        }
    }

    internal static class IEnumerableExtensions
    {
        public static IEnumerable<T> Abfrage<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            var query = new List<T>();

            foreach (var e in source)
                if (predicate(e))
                    query.Add(e);

            return query;
        }
    }
}
