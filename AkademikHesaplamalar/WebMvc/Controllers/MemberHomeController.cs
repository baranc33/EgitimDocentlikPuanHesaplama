using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class MemberHomeController : BaseController
    {

        public MemberHomeController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager) : base(userManager, signInManager)
        {
        }

        public async Task<IActionResult> Index()
        {
            //IList<string> Roles = await _userManager.GetRolesAsync(CurrentUser);
            //if (Roles.Contains("Admin"))
            //    return RedirectToAction("Index", "Admin");

            return View();
        }
    }
}
