using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models.DTOs.Auth
{
    public class RegisterUserDTO
    {
        [Required, MinLength(3)]
        public string FirstName { get; set; }
        [Required, MinLength(3)]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, PasswordPropertyText, MinLength(8)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
