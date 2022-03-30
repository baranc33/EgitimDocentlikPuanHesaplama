using Microsoft.AspNetCore.Identity;

namespace DocentlikPuanHesaplama.IdentityModel
{
    public class MyUser : IdentityUser
    {
        public string İmage { get; set; } = "";
    }
}
