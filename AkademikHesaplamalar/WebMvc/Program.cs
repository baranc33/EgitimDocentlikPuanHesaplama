
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
    opts.AccessDeniedPath = new PathString("/Member/AccessDenied");
});





builder.Services.AddMvc();
// Endpoint routing does not support hatasý için
// builder.Services.AddMvc(option => option.EnableEndpointRouting = false); 





var app = builder.Build();
app.UseDeveloperExceptionPage();// developer hata mesajlarý
app.UseStatusCodePages();// özellikle bir view dönmiyen sayfalarda hata içeriði yazar


//now handle other requests (default, static files, mvc actions, ...)
app.UseStaticFiles();





app.UseAuthentication();
app.UseAuthorization();// derste hoca bunu yazmiyor ama yazmayýnca hata veriyor
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");










app.Run();
