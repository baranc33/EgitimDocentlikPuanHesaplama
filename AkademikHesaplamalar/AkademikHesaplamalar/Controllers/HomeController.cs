using AkademikHesaplamalar.Models;
using AkademikHesaplamalar.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager) : base(userManager, signInManager)
        {
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
                    Resim= model.Password
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

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
                MyUser user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    // önce kayıtlı coockileri siliyoruz
                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    
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
