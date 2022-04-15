

using Core.Models;
using Core.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MyIdentityDbContext : IdentityDbContext<MyUser, MyRole, string>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
        {
        }

        public DbSet<MyContact> MyContacts { get; set; }
        public DbSet<AdminMember> AdminMember { get; set; }
        public DbSet<MyMessage> Messages { get; set; }
        public DbSet<EgitimEntity> EgitimEntities { get; set; } = default!;
        public DbSet<FenEntity> FenEntities { get; set; } = default!;
        public DbSet<FilolojiEntity> FilolojiEntities { get; set; } = default!;
        public DbSet<GuzelSanatlarEntity> GuzelSanatlarEntities { get; set; } = default!;
        public DbSet<HukukEntity> HukukEntities { get; set; } = default!;
        public DbSet<ilahiyatEntity> IlahiyatEntities { get; set; } = default!;
        public DbSet<MimarlikEntity> MimarlikEntities { get; set; } = default!;
        public DbSet<MuhendislikEntity> MuhendisEntities { get; set; } = default!;
        public DbSet<SaglikEntity> SaglikEntities { get; set; } = default!;
        public DbSet<SosyalEntity> SosyalEntities { get; set; } = default!;
        public DbSet<SporEntity> SporEntities { get; set; } = default!;
        public DbSet<ZiraatEntity> ZiraatEntities { get; set; } = default!;
    }
}

