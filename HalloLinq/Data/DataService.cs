using HalloLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Tynamix.ObjectFiller;

namespace HalloLinq.Data
{
    internal class DataService
    {
        private IEnumerable<Company> _companies;
        private IEnumerable<Employee> _employees;

        public DataService()
        {
            GenerateData();
        }

        public IEnumerable<Company> GetAllCompanies() => _companies;
        public IEnumerable<Employee> GetAllEmployees() => _employees;

        private void GenerateData()
        {
            var companyFiller = new Filler<Company>();
            companyFiller.Setup()
                .OnProperty(c => c.Country).Use(new CountryName())
                .OnProperty(c => c.City).Use(new CityName())
                .OnProperty(c => c.Name).Use(new RandomListItem<string>(
                    "zathquote",
                    "konfase",
                    "Zenstrip",
                    "Vivatraxkix",
                    "Jayzozlab",
                    "Volzap",
                    "Canhow",
                    "technokix",
                    "Xxx - quote",
                    "Betalane",
                    "Tempcon",
                    "tris - holdings",
                    "silholding",
                    "Gravelax",
                    "Moveplanet",
                    "Canelectronics",
                    "X - dontrans",
                    "Technonix",
                    "triolax",
                    "Voltzone",
                    "Streettone"
                    ))
                .OnProperty(c => c.Description).Use(new Lipsum(LipsumFlavor.InDerFremde))
                .OnProperty(c => c.Employees).IgnoreIt();

            var employeeFiller = new Filler<Employee>();
            employeeFiller.Setup()
                .OnProperty(e => e.Firstname).Use(new RealNames(NameStyle.FirstName))
                .OnProperty(e => e.Lastname).Use(new RealNames(NameStyle.LastName))
                .OnProperty(e => e.Email).Use(new EmailAddresses(new MnemonicString(), new DomainName(), ".at"))
                .OnProperty(e => e.Birthdate).Use(new DateTimeRange(
                    earliestDate: DateTime.Now.AddYears(-65), 
                    latestDate: DateTime.Now.AddYears(-15)))
                .OnProperty(e => e.Company).IgnoreIt()
                .OnProperty(e => e.CompanyId).IgnoreIt();

            var companies = companyFiller.Create(20);
            var random = new Random();

            foreach (var company in companies)
            {
                var employees = employeeFiller.Create(random.Next(5, 100));
               
                foreach(var e in employees)
                {
                    company.Employees.Add(e);
                    e.Company = company;
                    e.CompanyId = company.Id;
                }
            }

            _companies = companies;
            _employees = companies.SelectMany(c => c.Employees);
        }

        private class DomainName : IRandomizerPlugin<string>
        {
            public string GetValue() => "BundR";
        }
    }
}
