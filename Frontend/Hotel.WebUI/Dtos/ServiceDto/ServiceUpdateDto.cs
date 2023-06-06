using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class ServiceUpdateDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı linki giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması linki giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]
        public string Description { get; set; }

    }
}
