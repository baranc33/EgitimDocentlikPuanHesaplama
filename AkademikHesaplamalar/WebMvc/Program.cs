
using AspNetCore.SEOHelper;
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

app.UseXMLSitemap(builder.Environment.ContentRootPath);


app.MapControllerRoute("MemberDocent", "Docentlik-Puan-Hesaplamalar", new { controller = "MemberScience", action = "Index" });
app.MapControllerRoute("MemberEgitim", "E�itim-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Egitim" });
app.MapControllerRoute("MemberFen", "Fen-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Fen" });
app.MapControllerRoute("MemberFiloloji", "Filoloji-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Filoloji" });
app.MapControllerRoute("MemberGuzelsanatlar", "Guzelsanat-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "GuzelSanatlar" });
app.MapControllerRoute("MemberHukuk", "Hukuk-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Hukuk" });
app.MapControllerRoute("Memberilahiyat", "ilahiyat-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "ilahiyat" });
app.MapControllerRoute("MemberMimarlik", "Mimarl�k-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Mimarlik" });
app.MapControllerRoute("MemberMuhendis", "M�hendis-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Muhendis" });
app.MapControllerRoute("MemberSaglik", "Sa�l�k-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Saglik" });
app.MapControllerRoute("MemberSosyalBeseri", "SosyalBeseri-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "SosyalBeseri" });
app.MapControllerRoute("MemberZiraat", "Ziraat-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Ziraat" });
app.MapControllerRoute("MemberSpor", "Spor-Do�entlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Spor" });
app.MapControllerRoute("MemberAkademik", "Akademik-hesaplamalar", new { controller = "MemberHome", action = "Index" });




app.MapControllerRoute("hakkimizda", "Hakk�m�zda", new { controller = "Home", action = "About" });
app.MapControllerRoute("iletisim", "ileti�im", new { controller = "Home", action = "Contact" });
app.MapControllerRoute("Giris", "Giri�", new { controller = "Home", action = "Login" });
app.MapControllerRoute("kayit", "Kay�t", new { controller = "Home", action = "SignUp" });


app.MapControllerRoute("Docent", "Docentlik-Bilimleri-Puan-Hesaplama", new { controller = "Science", action = "Index" });
app.MapControllerRoute("Egitim", "E�itim-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Egitim" });
app.MapControllerRoute("Fen", "Fen-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Fen" });
app.MapControllerRoute("Filoloji", "Filoloji-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Filoloji" });
app.MapControllerRoute("Guzelsanatlar", "Guzelsanat-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "GuzelSanatlar" });
app.MapControllerRoute("Hukuk", "Hukuk-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Hukuk" });
app.MapControllerRoute("ilahiyat", "ilahiyat-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "ilahiyat" });
app.MapControllerRoute("Mimarlik", "Mimarl�k-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Mimarlik" });
app.MapControllerRoute("Muhendis", "M�hendis-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Muhendis" });
app.MapControllerRoute("Saglik", "Sa�l�k-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Saglik" });
app.MapControllerRoute("SosyalBeseri", "SosyalBeseri-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "SosyalBeseri" });
app.MapControllerRoute("Ziraat", "Ziraat-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Ziraat" });
app.MapControllerRoute("Spor", "Spor-Bilimleri-Do�entlik-Puan-Hesaplama", new { controller = "Science", action = "Spor" });
app.MapControllerRoute("Akademik", "Akademik-hesaplama", new { controller = "Home", action = "Index" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");










app.Run();
