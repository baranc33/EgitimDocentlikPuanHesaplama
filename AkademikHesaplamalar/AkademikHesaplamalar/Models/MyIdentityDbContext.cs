using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AkademikHesaplamalar.Models
{
    public class MyIdentityDbContext : IdentityDbContext<MyUser, MyRole, string>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<AdminMember> AdminMember { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}

