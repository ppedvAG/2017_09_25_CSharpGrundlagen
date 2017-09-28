using System.Collections.Generic;

namespace HalloLinq.Models
{
    internal class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}