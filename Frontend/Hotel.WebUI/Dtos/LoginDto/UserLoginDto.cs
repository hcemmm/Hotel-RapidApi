using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.LoginDto
{
    public class UserLoginDto
    {

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        public string Password { get; set; }
    }
}
