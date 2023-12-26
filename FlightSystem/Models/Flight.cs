using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public int FlightNum { get; set; } //ucus numarası
        public int PassengerNum { get; set; } // yolcu sayısı
        public string FlightDestination { get; set; }
        public string FlightDeparture { get; set; }
        public DateTime FlightDepartureDate { get; set; }
        public DateTime FlightDestinationDate { get; set; }
        public TimeSpan FlightDestinationTime { get; set; }
        public TimeSpan FlightDepartureTime { get; set; }
        public double EconomyClass { get; set; }
        public double BusinessClass { get; set; }
        public double SeatNum { get; set; }  //koltuk sayısı
    }
}
