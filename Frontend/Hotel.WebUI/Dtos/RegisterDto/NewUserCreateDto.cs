using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RegisterDto
{
    public class NewUserCreateDto
    {
        [Required(ErrorMessage = "Ad boş bırakılamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş bırakılamaz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-posta boş bırakılamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$", ErrorMessage = "Şifreniz en az 1 küçük harf, 1 büyük harf ve 1 sembol içermelidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar boş bırakılamaz")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
