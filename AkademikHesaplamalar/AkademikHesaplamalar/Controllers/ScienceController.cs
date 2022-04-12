using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class ScienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
