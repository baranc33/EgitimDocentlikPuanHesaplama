using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class Spor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
