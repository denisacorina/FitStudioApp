using System.ComponentModel.DataAnnotations;
using System.Data;

namespace FitStudio_App.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }

        public int RoleId { get; set; }
        public int? ClassId { get; set; }
        public Class? Class { get; set; }
    }
}
