using DocentlikPuanHesaplama.Helper.ConvertToModel;
using DocentlikPuanHesaplama.IdentityModel.Entity;
using DocentlikPuanHesaplama.Models;
using DocentlikPuanHesaplama.Models.DocentModels;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DocentlikPuanHesaplama.Controllers
{
    public class ScienceController : Controller
    {
      
        [HttpGet]
        public IActionResult Answer()
        {
            if (!TempData.ContainsKey("message"))
            {// Form sayfasına dönüş için tasarlandı
                var model = JsonSerializer.Deserialize<object>(TempData["model"].ToString());
                TempData["modelagain"] = JsonSerializer.Serialize(model);
                var action = JsonSerializer.Deserialize<string>(TempData["lasturl"].ToString());
                return RedirectToAction(action, "Science");
            }
            TempData.Remove("modelagain");
            Messages? m = JsonSerializer.Deserialize <Messages>(TempData["message"].ToString());
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
            // yeni açılan sayfa veya geri dönüş olduğunu tespit ediyorum.
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;
          
            return View();
        }
         
        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));


            Messages message =new ();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
            return RedirectToAction("Answer");
        }
     



        [HttpGet]
        public IActionResult Filoloji()
        {
            // yeni açılan sayfa veya geri dönüş olduğunu tespit ediyorum.
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Filoloji(FilolojiDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(FilolojiConvert.EgitimModelToEgitimEntity(model));


            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
            return RedirectToAction("Answer");
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
        public IActionResult Fen()
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


        [NonAction]
        private string GetUrl()
        {
            var url = HttpContext.Request.GetEncodedUrl();
            string[] words = url.Split('/');
            string action = words[words.Length - 1];
            return action;
        }
    }
}
