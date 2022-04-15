
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public class MyRole : IdentityRole
    {
        public string? RoleType { get; set; }
    }
}
