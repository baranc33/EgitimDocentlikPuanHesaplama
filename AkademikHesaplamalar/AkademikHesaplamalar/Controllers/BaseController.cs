using AkademikHesaplamalar.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class BaseController : Controller
    {
        protected UserManager<MyUser> _userManager { get; }
        protected SignInManager<MyUser> _signInManager { get; }

        protected RoleManager<MyRole>? _roleManager { get; }

        // kullanııcıyı bulma
        protected MyUser CurrentUser => _userManager.FindByNameAsync(User.Identity?.Name).Result;

        public BaseController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, RoleManager<MyRole>? roleManager = null)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }


        // model statete eror ekleme
        public void AddModelError(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {   // eğer en başta key gönderirsek gönderdiğimiz key ilgili inputun altında görünür
                // biz genel hata olarak gösterecez

                if (item.Description == "Invalid token.")
                {
                    ModelState.AddModelError("", "Link Daha önce kullanılmıştır.");
                }
                else
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
        }
    }
}
