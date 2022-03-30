using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocentlikPuanHesaplama.IdentityModel
{
    public class MyIdentityDbContext : IdentityDbContext<MyUser, MyRole, string>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> opt) : base(opt)
        {

        }




    }
}
