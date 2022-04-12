using Microsoft.AspNetCore.Identity;

namespace AkademikHesaplamalar.Models
{
    public class MyRole : IdentityRole
    {
        public string? RoleType { get; set; }
    }
}
