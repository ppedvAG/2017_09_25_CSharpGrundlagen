using HalloLinq.Data;
using System;
using System.Linq;

namespace HalloLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();

            var employees = dataService.GetAllEmployees();
            var companies = dataService.GetAllCompanies();

            #region Restriction

            // Linq Syntax
            //var query = from e in employees
            //            where e.Firstname[0] < 'H'
            //            select e;

            // Fluid API
            //var query = employees.Where(e => e.Firstname[0] > 'V');

            #endregion
            #region Ordering

            // Linq Syntax
            //var query = from e in employees
            //            orderby e.Firstname descending, e.Lastname ascending
            //            select e;

            // Fluid API
            //var query = employees.OrderBy(e => e.Firstname).ThenByDescending(e => e.Lastname);

            #endregion
            #region Projection

            // Linq Syntax
            //var query = from e in employees
            //            select new { Vorname = e.Firstname, Nachname = e.Lastname };

            // Fluid API
            //var query = employees.Select(e => new { Vorname = e.Firstname, Nachname = e.Lastname });

            #endregion
            #region Grouping

            // Linq Syntax
            //var query = from e in employees
            //            group e by e.Firstname[0] into g
            //            orderby g.Key
            //            select new { Anfangsbuchstabe = g.Key, Employees = g };

            // Fluid API
            //var query = employees
            //    .GroupBy(e => e.Firstname[0])
            //    .Select(g => new { Anfangsbuchstabe = g.Key, Employees = g })
            //    .OrderBy(g => g.Anfangsbuchstabe);

            #endregion
            #region Partitioning

            //var query = employees.OrderBy(e => e.Id).Skip(20).Take(20);

            #endregion
            #region Element Operators

            //var employee = employees.First();
            //var employee = employees.First(e => e.Firstname.StartsWith("H"));
            //var employee = employees.FirstOrDefault();
            //var employee = employees.FirstOrDefault(e => e.Firstname.StartsWith("H"));

            //var employee = employees.Single();
            //var employee = employees.Single(e => e.Firstname.StartsWith("H"));
            //var employee = employees.SingleOrDefault();
            //var employee = employees.SingleOrDefault(e => e.Firstname.StartsWith("H"));

            // Wird von SQL Server nicht unterstützt.
            //var employee = employees.Last();
            //var employee = employees.Last(e => e.Firstname.StartsWith("H"));
            //var employee = employees.LastOrDefault();
            //var employee = employees.LastOrDefault(e => e.Firstname.StartsWith("H"));

            #endregion
            #region Quantifying

            //bool allEmployeesStartWithA = employees.All(e => e.Firstname.StartsWith("A"));
            //bool anyEmployeesStartWithA = employees.Any(e => e.Firstname.StartsWith("A"));

            #endregion
            #region Aggregating

            //var count = employees.Count();
            //var count = employees.Count(e => e.Firstname.StartsWith("A"));
            //var count = employees.LongCount();
            //var count = employees.LongCount(e => e.Firstname.StartsWith("A"));

            //var min = employees.Min(e => e.Birthdate.Year);
            //Console.WriteLine($"Der älteste Employee ist geboren im Jahr {min}.");

            //var max = employees.Max(e => e.Birthdate.Year);
            //Console.WriteLine($"Der jüngste Employee ist geboren im Jahr {max}.");

            //var avg = employees.Average(e => e.Birthdate.Year);
            //Console.WriteLine($"Die Employees sind durchschittlich im Jahr {avg} geboren.");

            //var sum = employees.Sum(e =>
            //{
            //    var ageInTicks = (DateTime.Now - e.Birthdate).Ticks;
            //    var age = new DateTime(ageInTicks).Year;
            //    Console.WriteLine($"{e.Firstname} ist {age} Jahre alt.");
            //    return age;
            //});
            //Console.WriteLine($"Die Summe des Alters der Employees ist {sum}.");
            #endregion
            #region Inner Join

            // Linq Syntax
            //var query = from c in companies
            //            join e in employees on c.Id equals e.CompanyId
            //            select new { CompanyName = c.Name, Employee = e.Firstname };

            // Fluid API
            //var query = companies.Join(
            //    inner: employees,
            //    outerKeySelector: c => c.Id,
            //    innerKeySelector: e => e.CompanyId,
            //    resultSelector: (c, e) => new { CompanyName = c.Name, Employee = e.Firstname });

            #endregion
            #region Group Join

            // Linq Syntax
            //var query = from c in companies
            //            join e in employees on c.Id equals e.CompanyId into g
            //            select new { CompanyName = c.Name, CountEmployees = g.Count() };

            // Fluid API
            //var query = companies.GroupJoin(
            //    inner: employees,
            //    outerKeySelector: c => c.Id,
            //    innerKeySelector: e => e.CompanyId,
            //    resultSelector: (c, g) => new
            //    {
            //        CompanyName = c.Name,
            //        Employees = g.Select(e => new
            //        {
            //            e.Firstname,
            //            e.Lastname
            //        })
            //    });

            #endregion
            #region Cross Join

            // Linq Syntax
            //var whatever = from c in companies
            //               from e in employees
            //               select new
            //               {
            //                   CompanyName = c.Name,
            //                   e.Firstname,
            //                   e.Lastname
            //               };

            // Fluid API
            var whatever = companies.SelectMany(c => employees.Select(e => new
            {
                CompanyName = c.Name,
                e.Firstname,
                e.Lastname
            }));

            #endregion

            foreach (var item in whatever)
                Console.WriteLine($"{item.CompanyName, -15} | {item.Firstname,-15} | {item.Lastname}");

            Console.WriteLine(whatever.LongCount());

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.CompanyName);

            //    foreach (var e in item.Employees)
            //        Console.WriteLine($"\t{e.Firstname,-15} | {e.Lastname,-15}");
            //}

            //foreach (var e in query)
            //    Console.WriteLine($"\t{e.Firstname,-15} | {e.Lastname,-15} | {e.Email}");

            Console.ReadLine();
        }

        private class ProjectionExample
        {
            public string Vorname { get; set; }
            public string Lastname { get; set; }
        }
    }

    // Linqpad
}
