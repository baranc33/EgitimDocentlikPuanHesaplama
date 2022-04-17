using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebMvc.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager) : base(userManager, null, roleManager)
        {
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
