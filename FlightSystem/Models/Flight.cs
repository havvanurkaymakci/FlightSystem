﻿using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        [StringLength(6, ErrorMessage = "Lütfen geçerli bir numara giriniz ")]
        public string FlightNum { get; set; } //ucus numarası
        public int PassengerCapacity { get; set; } // yolcu kapasitesi
        public string FlightDestination { get; set; }
        public string FlightDeparture { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime FlightDepartureDate { get; set; }


        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime FlightDestinationDate { get; set; }
        public TimeSpan FlightDestinationTime { get; set; }
        public TimeSpan FlightDepartureTime { get; set; }
        public double EconomyClassPrice { get; set; }
        public double BusinessClassPrice { get; set; }
        public string airlineBusiness {  get; set; }    
      
    }
}
