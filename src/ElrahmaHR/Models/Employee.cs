using System;

namespace ElrahmaHR.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Department { get; set; } = string.Empty;
        
        public string FullName => $"{FirstName} {LastName}";
    }
}