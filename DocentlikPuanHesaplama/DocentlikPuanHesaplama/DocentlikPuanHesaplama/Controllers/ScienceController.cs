﻿using DocentlikPuanHesaplama.Helper.ConvertToModel;
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
      // get url yerine dinamik işlem yapmayı denicem
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
            TempData["lasturl"] = JsonSerializer.Serialize("Egitim");
            //TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
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
            TempData["lasturl"] = JsonSerializer.Serialize("Filoloji");
            //TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
            return RedirectToAction("Answer");
        }


        [HttpGet]
        public IActionResult Hukuk()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Hukuk(HukukDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(HukukConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize("Hukuk");
            return RedirectToAction("Answer");
        }




 

 
        [HttpGet]
        public IActionResult ilahiyat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult ilahiyat(ilahiyatDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(ilahiyatConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize("ilahiyat");
            return RedirectToAction("Answer");
        }



        
        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult SosyalBeseri(SosyalBeseriDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(SosyalBeseriConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize("SosyalBeseri");
            return RedirectToAction("Answer");
        }




       

        [HttpGet]
        public IActionResult Spor()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Spor(SporDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(SporConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            TempData["lasturl"] = JsonSerializer.Serialize("Spor");
            return RedirectToAction("Answer");
        }





        [HttpGet]
        public IActionResult GuzelSanatlar()
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
        public IActionResult Ziraat()
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
