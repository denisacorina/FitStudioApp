using System.ComponentModel.DataAnnotations;

namespace FitStudioAPI.Models
{
    public class RegisterUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
