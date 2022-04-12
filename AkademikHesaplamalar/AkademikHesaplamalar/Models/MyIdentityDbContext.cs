using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AkademikHesaplamalar.Models
{
    public class MyIdentityDbContext : IdentityDbContext<MyUser, MyRole, string>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
        {
        }


    }
}

