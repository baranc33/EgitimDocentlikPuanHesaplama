
using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Repositories;
using Service.Services;
using System.Reflection;
using WebMvc.Helpers.Extensions.IServiceCollectionExtensions;
using WebMvc.Helpers.Validaton;

var builder = WebApplication.CreateBuilder(args);


string con = "";
if (builder.Environment.IsDevelopment())
    //con = builder.Configuration["ConnectionStrings:ProductionConnectionString"];
    con = builder.Configuration["ConnectionStrings:DefaultConnectionString"];
else
    con = builder.Configuration["ConnectionStrings:ProductionConnectionString"];



// migration yaparken repository se�ili set a start up Bu dosya n�n assembly si se�ili
builder.Services.AddScopedExtens();

builder.Services.AddDbContext<MyIdentityDbContext>(opts =>
{
    opts.UseSqlServer(con,// manuel olarak projenin ismini verebiliriz fakat assemblyden proje ad�n� almak daha sa�l�kl� olur
            x => x.MigrationsAssembly(Assembly.GetAssembly(typeof(MyIdentityDbContext)).GetName().Name));
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


}).AddEntityFrameworkStores<MyIdentityDbContext>().AddPasswordValidator<CustomPasswordValidator>()
.AddUserValidator<CustomUserValidator>().AddErrorDescriber<CustomIdentityErrorDescriber>()
.AddDefaultTokenProviders();




CookieBuilder cookieBuilder = new CookieBuilder();
cookieBuilder.Name = "MyBlog";
cookieBuilder.HttpOnly = false;
cookieBuilder.SameSite = SameSiteMode.Lax;
cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;


builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.LoginPath = new PathString("/Home/Login");
    opts.LogoutPath = new PathString("/Member/Logout");
    opts.Cookie = cookieBuilder;
    opts.SlidingExpiration = true;
    opts.ExpireTimeSpan = System.TimeSpan.FromDays(60);
    // role eri�imi yoksa y�nlendirme
    opts.AccessDeniedPath = new PathString("/Member/AccessDenied");
});





builder.Services.AddMvc();
// Endpoint routing does not support hatas� i�in
// builder.Services.AddMvc(option => option.EnableEndpointRouting = false); 





var app = builder.Build();
app.UseDeveloperExceptionPage();// developer hata mesajlar�
app.UseStatusCodePages();// �zellikle bir view d�nmiyen sayfalarda hata i�eri�i yazar


//now handle other requests (default, static files, mvc actions, ...)
app.UseStaticFiles();





app.UseAuthentication();
app.UseAuthorization();// derste hoca bunu yazmiyor ama yazmay�nca hata veriyor

app.MapControllerRoute("default14", "Docentlik-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Index" });
app.MapControllerRoute("default13", "filoloji-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Filoloji" });
app.MapControllerRoute("default12", "hukuk-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Hukuk" });
app.MapControllerRoute("default11", "ilahiyat-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "ilahiyat" });
app.MapControllerRoute("default10", "spor-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Spor" });
app.MapControllerRoute("default10", "fen-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Fen" });
app.MapControllerRoute("default9", "sosyalbeseri-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "SosyalBeseri" });
app.MapControllerRoute("default8", "muhendis-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Muhendis" });
app.MapControllerRoute("default7", "ziraat-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Ziraat" });
app.MapControllerRoute("default6", "mimarlik-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Mimarlik" });
app.MapControllerRoute("default5", "saglik-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Saglik" });
app.MapControllerRoute("default4", "egitim-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "Egitim" });
app.MapControllerRoute("default3", "guzelsanatlar-bilimleri-do�entlik-puan-hesaplama", new { controller = "Science", action = "GuzelSanatlar" });
app.MapControllerRoute("default2", "Akademik-hesaplama", new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");










app.Run();
