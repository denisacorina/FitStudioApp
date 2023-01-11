using MessagePack;

namespace FitStudioAPI.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string JobOcupation { get; set; }

    }
}
