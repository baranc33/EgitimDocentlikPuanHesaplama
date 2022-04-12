using Microsoft.AspNetCore.Identity;

namespace AkademikHesaplamalar.Models
{
    public class MyUser : IdentityUser
    {
        public string? Sehir { get; set; }
        public string? Resim { get; set; }
    }
}
