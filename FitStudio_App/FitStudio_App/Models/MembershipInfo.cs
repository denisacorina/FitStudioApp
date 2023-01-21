using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models
{
    public class MembershipInfo
    {
        [Key]
        public int MembershipId { get; set; }
        public Boolean isActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }
        public MembershipType Type { get; set; }
    }
}
