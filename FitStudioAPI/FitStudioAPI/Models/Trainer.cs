using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace FitStudioAPI.Models
{
    public class Trainer : Employee
    {

        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssignedClass { get; set; }
        public string ImageUrl { get; set; }

    }
}
