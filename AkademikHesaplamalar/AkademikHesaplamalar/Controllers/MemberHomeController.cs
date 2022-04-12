using AkademikHesaplamalar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class MemberHomeController : BaseController
    {

        public MemberHomeController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager) : base(userManager, signInManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
