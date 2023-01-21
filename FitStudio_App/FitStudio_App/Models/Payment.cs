using System.ComponentModel.DataAnnotations;

namespace FitStudio_App.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
