using System;

namespace HalloLinq.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}