using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class MemberTesvikController : Controller
    {
        public IActionResult TesvikHesaplama()
        {
            return View();
        }
    }
}
