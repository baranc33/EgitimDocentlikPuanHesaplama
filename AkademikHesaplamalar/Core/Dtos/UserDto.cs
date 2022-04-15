using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Kullanıcı Adı Zorunludur")]
        //[Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; } = "";

        [Required(ErrorMessage = "Email Adresi Zorunludur")]
        //[Display(Name = "Email Adresi")]
        [EmailAddress(ErrorMessage = "Email Adresiniz Doğru Formatta değildir")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Şifre Girmek Zorunludur")]
        //[Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";


    }
}
