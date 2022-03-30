using Microsoft.AspNetCore.Mvc;

namespace DocentlikPuanHesaplama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
