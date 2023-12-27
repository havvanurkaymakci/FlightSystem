using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Ticket
    {

        [Key]
        public int TicketId { get; set; }     
        public int FlightID { get; set; }
        public int TicketNum { get; set; } //Alinan bilet sayisi

        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
        public string TicketType{ get; set; }
        
    }
}
