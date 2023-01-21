using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleType { get; set; }

    }
}
