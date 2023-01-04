using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace FitStudioAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        override
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public char? Gender { get; set; }
        public string? Address { get; set; }
        //public Role Role { get; set; }
        //public List<MembershipInfo>? MembershipInfos { get; set; }
        public bool? RememberMe { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
