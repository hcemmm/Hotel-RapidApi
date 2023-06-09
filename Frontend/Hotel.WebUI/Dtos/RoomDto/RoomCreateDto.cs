using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RoomDto
{
    public class RoomCreateDto
    {
        [Required(ErrorMessage = "Oda numarası giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Oda resmi giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Oda fiyatı giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Oda başlığı giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Oda yatak sayısı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Oda banyo sayısı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string BathCount { get; set; }

        [Required(ErrorMessage = "Oda wifi durumu giriniz")]
        public bool Wifi { get; set; }

        [Required(ErrorMessage = "Oda açıklaması giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Description { get; set; }
    }
}
