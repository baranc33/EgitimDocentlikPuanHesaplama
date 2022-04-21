using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class TesvikController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TesvikHesaplama()
        {
            return View();
        }
    }
}
