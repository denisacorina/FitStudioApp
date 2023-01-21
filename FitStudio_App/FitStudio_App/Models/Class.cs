using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string? Activity { get; set; }
        public string? Description { get; set; }
        public string? Intensity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string WeekDay { get; set; }
        public int UserId { get; set; }
        public List<User> Users { get; set; }
    }
}
