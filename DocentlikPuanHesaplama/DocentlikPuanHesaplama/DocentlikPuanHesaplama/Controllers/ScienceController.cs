using DocentlikPuanHesaplama.IdentityModel.Entity;
using DocentlikPuanHesaplama.Models;
using DocentlikPuanHesaplama.Models.Egitim;
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
            {
                var model = JsonSerializer.Deserialize<object>(TempData["model"].ToString());
                TempData["modelagain"] = JsonSerializer.Serialize(model);
                var action = JsonSerializer.Deserialize<string>(TempData["lasturl"].ToString());

                return RedirectToAction(action, "Science");
            }

            Messages m = JsonSerializer.Deserialize <Messages>(TempData["message"].ToString());
           
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
            if (TempData.ContainsKey("modelagain"))
            {
                //EgitimDocentModel models = JsonSerializer.Deserialize<EgitimDocentModel>(TempData["modelagain"].ToString());

                ViewBag.OldData = true;
                return View();
            }
            ViewBag.OldData = false;

            return View();
        }
    
        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {/*********** Hesaplama yaparken ilk indexten geleni hesaplama o numune olan************/

            EgitimEntity entity = new();


            if (model.UluslarArasiAdoktora.Count() > 1)
            {
                for (int i = 1; i < model.UluslarArasiAdoktora.Count(); i++)
                {

                   if(model.uluslararasiAhatirlatici[i]!=null) entity.uluslararasiAhatirlatici += model.uluslararasiAhatirlatici[i].ToString() + "/";
                    entity.UluslarArasiAdoktora += model.UluslarArasiAdoktora[i].ToString() + "/";
                    entity.UluslarArasiAyazarsayisi += model.UluslarArasiAyazarsayisi[i].ToString() + "/";
                    entity.UluslarArasiAmakalesayisi+= model.UluslarArasiAmakalesayisi[i].ToString() + "/";
                }

            }
            

            Messages message =new ();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["model"] = JsonSerializer.Serialize(model);
            //TempData["model"] = JsonSerializer.Serialize(entity);
            TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
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


        private string GetUrl()
        {
            var url = HttpContext.Request.GetEncodedUrl();
            string[] words = url.Split('/');
            string action = words[words.Length - 1];
            return action;
        }
    }
}
