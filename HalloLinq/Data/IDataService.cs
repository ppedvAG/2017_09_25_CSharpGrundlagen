using System.Collections.Generic;
using HalloLinq.Models;

namespace HalloLinq.Data
{
    internal interface IDataService
    {
        IEnumerable<Company> GetAllCompanies();
        IEnumerable<Employee> GetAllEmployees();
    }
}