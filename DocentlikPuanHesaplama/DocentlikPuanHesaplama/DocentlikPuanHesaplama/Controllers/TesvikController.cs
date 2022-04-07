using DocentlikPuanHesaplama.IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DocentlikPuanHesaplama.Controllers
{
    public class TesvikController : Controller
    {
        public UserManager<MyUser> userManager { get; }
        public SignInManager<MyUser> signInManager { get; }
        public TesvikController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
