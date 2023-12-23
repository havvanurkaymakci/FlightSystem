using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public int FlightNum { get; set; } //ucus numarası
        public int PassengerNum { get; set; }
        public string FlightDestination { get; set; }
        public string FlightDepartue { get; set; }
        public DateTime FlightDepartueDate { get; set; }
        public DateTime FlightDestinationDate { get; set; }
        public TimeSpan FlightDestinationTime { get; set; }
        public TimeSpan FlightDepartueTime { get; set; }
        public double EconomyClass { get; set; }
        public double BusinessClass { get; set; }
        public double SeatNum { get; set; }  //koltuk sayısı
    }
}
