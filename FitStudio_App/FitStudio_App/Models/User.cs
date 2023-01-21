using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitStudio_App.Models
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Byte[] PaswordHash { get; set; }
        public Byte[] PaswordSalt { get; set; }
        public int? PhoneNo { get; set; }
        public char? Gender { get; set; }
        public string? Address { get; set; }

        [ForeignKey("RoleId")]
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public ICollection<MembershipInfo>? MembershipInfos { get; set; }
        public string? Token { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime TokenExpires { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
