using System.ComponentModel.DataAnnotations;

namespace FlightSystem.Models
{
    public class Passenger
    {
        [Key]

        public int PassengerId { get; set; }

        public int TicketNum { get; set; }


        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        public string PassengerName { get; set; } // yolcu kapisetesi


        [Required(ErrorMessage = "Kullanıcı soyadı alanı zorunludur.")]
        public string PassengerSurname { get; set; }


        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime Birthday { get; set; }


        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public string passengerGender { get; set; }


        // public string passengerNum { get; set; }

        [StringLength(11, ErrorMessage = "Lütfen geçerli bir numara giriniz ")]
        [Required(ErrorMessage = " Kimlik numarası alanı zorunludur.")]
        public string TCNumber { get; set; }


        [Required(ErrorMessage = "Passport Numarası alanı zorunludur.")]
        [RegularExpression(@"^[A-PR-WY][1-9]\d\s?\d{3}[1-9]$", ErrorMessage = "Geçersiz pasaport numarası.")]
        public string PassportNum { get; set; }


        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail giriniz")]
        [Required(ErrorMessage = "Mail adresi alanı zorunludur.")]
        public string UserMail { get; set; }


        [Phone(ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz")]
        [Required(ErrorMessage = "Telefon numarası alanı zorunludur.")]
        public string UserPhone { get; set; }
    }
}

