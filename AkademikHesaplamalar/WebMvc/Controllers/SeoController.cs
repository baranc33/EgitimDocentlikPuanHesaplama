using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class SeoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
