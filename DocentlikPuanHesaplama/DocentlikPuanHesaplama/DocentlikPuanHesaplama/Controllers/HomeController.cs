using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DocentlikPuanHesaplama.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<MyUser> userManager { get; }
        public SignInManager<MyUser> signInManager { get; }
        public HomeController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                MyUser user = new MyUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    İmage= model.Password
                };

                IdentityResult result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        // eğer en başta key gönderirsek gönderdiğimiz key ilgili inputun altında görünür
                        // biz genel hata olarak gösterecez
                        ModelState.AddModelError("", item.Description);

                    }
                }

            }
            return View(model);
        }



        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
            {
            if (ModelState.IsValid)
            {
                MyUser user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    // önce kayıtlı coockileri siliyoruz
                    await signInManager.SignOutAsync();

                    // 1. true/false program.cs te belirttiğimiz coockie ömrünü aktif eder
                    // 2. true/false başarısız girişlerde kulanıcı kitleme
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    //if (result.IsNotAllowed)//kullanıcı kitliyken doğru giriş yaparsa
                    //if (result.Succeeded)// işlem başarılımı
                    //if (result.IsLockedOut)//kullanıcı kitlimi değilmi
                    //if (result.RequiresTwoFactor)// iki faktörlü koruma açıkmı?
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Member");
                    }



                }
            
            }



            ModelState.AddModelError("", "Geçersiz kullanıcı adı veya  şifresi");


            return View(model);
        }


        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }
    }
}
