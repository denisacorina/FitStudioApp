using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
