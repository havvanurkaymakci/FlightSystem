using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CardId { get; set; }
        public int TotalAmount { get; set; }
        public bool CardType { get; set; }
        public DateTime CardDate { get; set; }
        public int CVV { get; set; } 

    }
}
