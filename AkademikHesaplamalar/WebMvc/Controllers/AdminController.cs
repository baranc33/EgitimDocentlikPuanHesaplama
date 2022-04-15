using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
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
