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
        public DbSet<FenEntity> FenEntities { get; set; }= default!;
        public DbSet<FilolojiEntity> FilolojiEntities { get; set; }= default!;
        public DbSet<HukukEntity> HukukEntities { get; set; }= default!;
        public DbSet<ilahiyatEntity> IlahiyatEntities { get; set; }= default!;
        public DbSet<MimarlikEntity> MimarlikEntities { get; set; }= default!;
        public DbSet<MuhendisEntity> MuhendisEntities { get; set; }= default!;
        public DbSet<SaglikEntity> SaglikEntities { get; set; }= default!;
        public DbSet<SosyalEntity> SosyalEntities { get; set; }= default!;
        public DbSet<SporEntity> SporEntities { get; set; }= default!;
        public DbSet<ZiraatEntity> ZiraatEntities { get; set; }= default!;


    }
}
