
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



// migration yaparken repository seçili set a start up Bu dosya nýn assembly si seçili
builder.Services.AddScopedExtens();

builder.Services.AddDbContext<MyIdentityDbContext>(opts =>
{
    opts.UseSqlServer(con,// manuel olarak projenin ismini verebiliriz fakat assemblyden proje adýný almak daha saðlýklý olur
            x => x.MigrationsAssembly(Assembly.GetAssembly(typeof(MyIdentityDbContext)).GetName().Name));
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
    // role eriþimi yoksa yönlendirme
    opts.AccessDeniedPath = new PathString("/Home/AccessDenied");
});





builder.Services.AddMvc();
// Endpoint routing does not support hatasý için
// builder.Services.AddMvc(option => option.EnableEndpointRouting = false); 





var app = builder.Build();
app.UseDeveloperExceptionPage();// developer hata mesajlarý
//app.UseStatusCodePages();// özellikle bir view dönmiyen sayfalarda hata içeriði yazar
app.UseStatusCodePagesWithReExecute("/Home/Page404","?code={0}");

//now handle other requests (default, static files, mvc actions, ...)
app.UseStaticFiles();





app.UseAuthentication();
app.UseAuthorization();// derste hoca bunu yazmiyor ama yazmayýnca hata veriyor

app.UseXMLSitemap(builder.Environment.ContentRootPath);


app.MapControllerRoute("Found404", "Doçentlik-puan-Hesaplama", new { controller = "home", action = "Page404" });



app.MapControllerRoute("Membertesvik", "Akademik-Tesvik-Hesaplamalar", new { controller = "MemberScience", action = "TesvikHesaplama" });
app.MapControllerRoute("MemberDocent", "Docentlik-Bilimleri-Puan-Hesaplamalar", new { controller = "MemberScience", action = "Index" });
app.MapControllerRoute("MemberEgitim", "Egitim-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Egitim" });
app.MapControllerRoute("MemberFen", "Fen-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Fen" });
app.MapControllerRoute("MemberFiloloji", "Filoloji-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Filoloji" });
app.MapControllerRoute("MemberGuzelsanatlar", "Guzelsanat-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "GuzelSanatlar" });
app.MapControllerRoute("MemberHukuk", "Hukuk-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Hukuk" });
app.MapControllerRoute("Memberilahiyat", "ilahiyat-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "ilahiyat" });
app.MapControllerRoute("MemberMimarlik", "Mimarlýk-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Mimarlik" });
app.MapControllerRoute("MemberMuhendis", "Mühendis-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Muhendis" });
app.MapControllerRoute("MemberSaglik", "Saðlýk-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Saglik" });
app.MapControllerRoute("MemberSosyalBeseri", "SosyalBeseri-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "SosyalBeseri" });
app.MapControllerRoute("MemberZiraat", "Ziraat-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Ziraat" });
app.MapControllerRoute("MemberSpor", "Spor-Docentlik-Puan-Hesaplama", new { controller = "MemberScience", action = "Spor" });
app.MapControllerRoute("MemberAkademik", "Akademik-hesaplamalar", new { controller = "MemberHome", action = "Index" });
app.MapControllerRoute("Memberiletisim", "Memberiletisim", new { controller = "MemberHome", action = "Contact" });




app.MapControllerRoute("hakkimizda", "Hakkimizda", new { controller = "Home", action = "About" });
app.MapControllerRoute("iletisim", "iletisim", new { controller = "Home", action = "Contact" });
app.MapControllerRoute("Giris", "Giris", new { controller = "Home", action = "Login" });
app.MapControllerRoute("kayit", "Kayit", new { controller = "Home", action = "SignUp" });
app.MapControllerRoute("sifreyenile", "sifre-yenile", new { controller = "Home", action = "ResetPassword" });


app.MapControllerRoute("TesvikMadde", "Tesvik-Hesaplama", new { controller = "Tesvik", action = "Index" });
app.MapControllerRoute("Tesvik", "Akademik-Tesvik-Hesaplama", new { controller = "Tesvik", action = "TesvikHesaplama" });
app.MapControllerRoute("Docent", "Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Index" });
app.MapControllerRoute("Egitim", "Egitim-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Egitim" });
app.MapControllerRoute("Fen", "Fen-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Fen" });
app.MapControllerRoute("Filoloji", "Filoloji-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Filoloji" });
app.MapControllerRoute("Guzelsanatlar", "Guzelsanat-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "GuzelSanatlar" });
app.MapControllerRoute("Hukuk", "Hukuk-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Hukuk" });
app.MapControllerRoute("ilahiyat", "ilahiyat-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "ilahiyat" });
app.MapControllerRoute("Mimarlik", "Mimarlik-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Mimarlik" });
app.MapControllerRoute("Muhendis", "Muhendis-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Muhendis" });
app.MapControllerRoute("Saglik", "Saglik-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Saglik" });
app.MapControllerRoute("SosyalBeseri", "SosyalBeseri-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "SosyalBeseri" });
app.MapControllerRoute("Ziraat", "Ziraat-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Ziraat" });
app.MapControllerRoute("Spor", "Spor-Bilimleri-Docentlik-Puan-Hesaplama", new { controller = "Science", action = "Spor" });
app.MapControllerRoute("Akademik", "Akademik-hesaplama", new { controller = "Home", action = "Index" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");










app.Run();
