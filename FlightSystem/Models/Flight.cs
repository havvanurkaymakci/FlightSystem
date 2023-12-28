using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        [Display(Name="Uçuş numarası")]
        [StringLength(6, ErrorMessage = "Lütfen geçerli bir numara giriniz ")]
        public string FlightNum { get; set; } //ucus numarası

        [Display(Name = "yolcu kapasitesi")]
        public int PassengerCapacity { get; set; } // yolcu kapasitesi

        [Display(Name = "Kalkış yeri")]
        public string FlightDeparture { get; set; }

        [Display(Name = "Varış yeri")]
        public string FlightDestination { get; set; }

         [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "kalkış tarihi")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime FlightDepartureDate { get; set; }

           [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "varış tarihi")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime FlightDestinationDate { get; set; }


        [Display(Name = "kalkış saati")]
        public TimeSpan FlightDepartureTime { get; set; }

        [Display(Name = "varış saati")]
        public TimeSpan FlightDestinationTime { get; set; }


        [Display(Name = "Ekkonomi fiyatı")]
        public double EconomyClassPrice { get; set; }


        [Display(Name = "Business fiyatı")]
        public double BusinessClassPrice { get; set; }

        [Display(Name = "Havayolu şirketi")]
        public string airlineBusiness {  get; set; }    
      
    }
}
