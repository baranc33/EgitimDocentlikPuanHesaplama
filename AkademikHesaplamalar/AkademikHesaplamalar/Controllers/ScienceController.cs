using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class ScienceController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Egitim()
        {
            //ViewBag.OldData = false;
            //if (TempData.ContainsKey("modelagain"))
            //    ViewBag.OldData = true;

            return View();
        }

        //[HttpPost]
        //public IActionResult Egitim(EgitimDocentModel model)
        //{
        //    TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
        //    Messages message = new();
        //    message = model.Hesapla();
        //    TempData["message"] = JsonSerializer.Serialize(message);
        //    //TempData["lasturl"] = JsonSerializer.Serialize("Egitim");
        //    //TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
        //    ViewBag.OldData = false;

        //    return RedirectToAction("Answer", "Science", new { link = "Egitim" });

        //}
    }
}
