using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.Validation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


CookieBuilder cookieBuilder = new CookieBuilder();
cookieBuilder.Name = "Docent";
cookieBuilder.HttpOnly = false;
cookieBuilder.SameSite = SameSiteMode.Lax;
cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;



var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.LoginPath = new PathString("/Home/Login");
    opts.LogoutPath = new PathString("/Member/LogOut");
    opts.Cookie = cookieBuilder;
    opts.SlidingExpiration = true;
    opts.ExpireTimeSpan = System.TimeSpan.FromDays(60);
    opts.AccessDeniedPath = new PathString("/Member/AccessDenied");
});


builder.Services.AddMvc();

string con = builder.Configuration["ConnectionStrings:DefaultConnectionString"];
builder.Services.AddDbContext<MyIdentityDbContext>(opts =>
{
    opts.UseSqlServer(con);
});// entity framework db baðlantýsý

// ýdentity Baðlantýýsý
builder.Services.AddIdentity<MyUser, MyRole>(opt =>
{
    opt.User.RequireUniqueEmail = true;//evet tek mail olmalý
    opt.User.AllowedUserNameCharacters = "çiöüðÐÝÇÖÜabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";

    opt.Password.RequiredLength = 4;//minimun deðer
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireDigit = false;

}).AddEntityFrameworkStores<MyIdentityDbContext>()
.AddErrorDescriber<CustomIdentityErrorDescriber>();



var app = builder.Build();
app.UseDeveloperExceptionPage();// developer hata mesajlarý
app.UseStatusCodePages();// özellikle bir content dönmiyen sayfalarda hata içeriði
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
