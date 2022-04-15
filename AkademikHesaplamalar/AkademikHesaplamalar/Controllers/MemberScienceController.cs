using AkademikHesaplamalar.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class MemberScienceController : BaseController
    {
        public MemberScienceController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager) : base(userManager, signInManager)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
