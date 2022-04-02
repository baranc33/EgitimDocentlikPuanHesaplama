using DocentlikPuanHesaplama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DocentlikPuanHesaplama.Controllers
{
    public class ScienceController : Controller
    {
      
        [HttpGet]
        public IActionResult Answer()
        {
            Messages m = JsonSerializer.Deserialize <Messages>(TempData["message"].ToString());
            string[] a = new string[]{ "Hata1", "Hata2"};
            m.ErrorMessage = a;
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
            return View();
        }
    
        [HttpPost]
        public IActionResult Egitim(string[] EgitimBhatirlatici)
        {
            Messages m = new Messages();
            if (EgitimBhatirlatici.Length > 1)
            {
                m.message = "Bilgi Var";
            }
            else
            {
                m.message = "Bilgi Yok";
            }
            TempData["message"] = JsonSerializer.Serialize(m);
            return RedirectToAction("Answer");
        }
        [HttpGet]
        public IActionResult Fen()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Filoloji()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GuzelSanatlar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Hukuk()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ilahiyat()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Mimarlik()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Muhendis()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Saglik()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ziraat()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Spor()
        {
            return View();
        }


    }
}
