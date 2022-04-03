using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.Validation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


CookieBuilder cookieBuilder = new ();
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
    opts.ExpireTimeSpan = System.TimeSpan.FromDays(30);
    opts.AccessDeniedPath = new PathString("/Member/AccessDenied");
});


builder.Services.AddMvc();
string con = "";
if (builder.Environment.IsDevelopment())
{
    con = builder.Configuration["ConnectionStrings:DefaultConnectionString"];
}
else
{
    con = builder.Configuration["ConnectionStrings:ProductionConnectionString"];
}

builder.Services.AddDbContext<MyIdentityDbContext>(opts =>
{
    opts.UseSqlServer(con);
});// entity framework db ba�lant�s�

// �dentity Ba�lant��s�
builder.Services.AddIdentity<MyUser, MyRole>(opt =>
{
    opt.User.RequireUniqueEmail = true;//evet tek mail olmal�
    opt.User.AllowedUserNameCharacters = "�i��������abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";

    opt.Password.RequiredLength = 4;//minimun de�er
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireDigit = false;

}).AddEntityFrameworkStores<MyIdentityDbContext>()
.AddErrorDescriber<CustomIdentityErrorDescriber>();



/* Session*/
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".AdventureWorks.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.IsEssential = true;
});

var app = builder.Build();
app.UseDeveloperExceptionPage();// developer hata mesajlar�
app.UseStatusCodePages();// �zellikle bir content d�nmiyen sayfalarda hata i�eri�i
app.UseStaticFiles();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
