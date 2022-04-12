using AkademikHesaplamalar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager) : base(userManager, null, roleManager)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
