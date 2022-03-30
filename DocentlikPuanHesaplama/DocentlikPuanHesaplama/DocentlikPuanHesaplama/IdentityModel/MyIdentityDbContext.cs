using DocentlikPuanHesaplama.IdentityModel.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocentlikPuanHesaplama.IdentityModel
{
    public class MyIdentityDbContext : IdentityDbContext<MyUser, MyRole, string?>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> opt) : base(opt)
        {

        }
        /*
         Veri tabanına bilgiler  diziler string?e çevrilerek yazılacak
         Yanstırken ilgili fonksyon veri tabanındaki yapıları dizilere çevirerek dönecek
         hesaplama işlemi yine ve total bilgiler tekrardan hesaplanacaktır.
         */
        public DbSet<EgitimEntity> EgitimEntities { get; set; }= default!;


    }
}
