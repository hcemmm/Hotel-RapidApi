using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.GuestDto
{
    public class GuestCreateDto
    {
        [Required(ErrorMessage = "Ad giriniz")]
        [MinLength(2, ErrorMessage = "Ad en kısa 2 karakter olabilir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad giriniz")]
        [MinLength(2, ErrorMessage = "Soyad en kısa 2 karakter olabilir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Şehir giriniz")]
        [MinLength(4, ErrorMessage = "Şehir adı en kısa 4 karakter olabilir")]
        public string City { get; set; }
    }
}
