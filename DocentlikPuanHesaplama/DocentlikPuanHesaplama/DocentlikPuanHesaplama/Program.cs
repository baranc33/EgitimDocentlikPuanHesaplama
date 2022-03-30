using DocentlikPuanHesaplama.IdentityModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

string con = builder.Configuration["ConnectionStrings:DefaultConnectionString"];
builder.Services.AddDbContext<IdentityDbContext>(opts =>
{
    opts.UseSqlServer(con);
});// entity framework db baðlantýsý

// ýdentity Baðlantýýsý
builder.Services.AddIdentity<MyUser, MyRole>().AddEntityFrameworkStores<MyIdentityDbContext>();
