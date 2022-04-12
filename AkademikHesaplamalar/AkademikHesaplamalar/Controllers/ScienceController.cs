using AkademikHesaplamalar.Helpers.ConvertToModel;
using AkademikHesaplamalar.ViewModels.DocentModels;
using AkademikHesaplamalar.ViewModels.DocentModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AkademikHesaplamalar.Controllers
{
    public class ScienceController : Controller
    {
        [HttpGet]
        public IActionResult Answer(string link)
        {

            ViewBag.link = link;
            if (!TempData.ContainsKey("message"))
            {// Form sayfasına dönüş için tasarlandı
                TempData["modelagain"] = TempData["model"]?.ToString();
                TempData.Remove("model");
                return RedirectToAction(link, "Science");
            }
            TempData.Remove("modelagain");
            Messages? m = JsonSerializer.Deserialize<Messages>(TempData["message"]?.ToString());
            TempData.Remove("message");

            return View(m);
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Egitim()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            ViewBag.OldData = false;

            return RedirectToAction("Answer", "Science", new { link = "Egitim" });
        }
    }
}
