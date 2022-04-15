
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public class MyUser : IdentityUser
    {
        public string? Sehir { get; set; }
        public string? Resim { get; set; }
    }
}
