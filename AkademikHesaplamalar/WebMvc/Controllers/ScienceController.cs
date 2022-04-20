using WebMvc.Helpers.ConvertToModel;
using WebMvc.Models.DocentModels;
using WebMvc.Models.DocentModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebMvc.Controllers
{
    public class ScienceController : Controller
    {
        [HttpGet]
        public IActionResult Answer(string link)
        {
            ViewBag.link = link;
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
            if (TempData.ContainsKey("model"))   ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Egitim" });
        }


        [HttpGet]
        public IActionResult Filoloji()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Filoloji(FilolojiDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FilolojiConvert.FilolojiModelToFilolojiEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Filoloji" });
        }


        [HttpGet]
        public IActionResult Hukuk()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Hukuk(HukukDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(HukukConvert.HukukModelToHukukEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Hukuk" });
        }



        [HttpGet]
        public IActionResult ilahiyat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult ilahiyat(ilahiyatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ilahiyatConvert.ilahiyatModelToilahiyetEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "ilahiyat" });
        }


        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult SosyalBeseri(SosyalBeseriDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SosyalBeseriConvert.SosyalModelToSosyalEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "SosyalBeseri" });
        }




        [HttpGet]
        public IActionResult Spor()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Spor(SporDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SporConvert.SporModelToSporEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Spor" });
        }





        [HttpGet]
        public IActionResult Muhendis()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Muhendis(MuhendislikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MuhendislikConvert.MuhendislikModelToMuhendislikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Muhendis" });
        }





        [HttpGet]
        public IActionResult Fen()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Fen(FenDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FenConvert.FenModelToFenEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Fen" });
        }




        [HttpGet]
        public IActionResult Ziraat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Ziraat(ZiraatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ZiraatConvert.ZiraatModelToZiraatEntity(model));
            Messages  message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Ziraat" });
        }





        [HttpGet]
        public IActionResult Mimarlik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Mimarlik(MimarlikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MimarlikConvert.MimarlikModelToMimarlikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Mimarlik" });
        }





        [HttpGet]
        public IActionResult Saglik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult Saglik(SaglikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SaglikConvert.SaglikModelToSaglikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Saglik" });
        }



        [HttpGet]
        public IActionResult GuzelSanatlar()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [HttpPost]
        public IActionResult GuzelSanatlar(GuzelSanatlarDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(GuzelSanatlarConvert.GuzelSanatlarModelToGuzelSanatlarEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "GuzelSanatlar" });
        }







    }
}
