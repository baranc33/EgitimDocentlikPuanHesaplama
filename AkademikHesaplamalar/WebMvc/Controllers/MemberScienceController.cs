﻿using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models.DocentModels.Models;
using System.Text.Json;
using WebMvc.Models.DocentModels;
using WebMvc.Helpers.ConvertToModel;
using Microsoft.AspNetCore.Authorization;

namespace WebMvc.Controllers
{
    public class MemberScienceController : BaseController
    {
        public MemberScienceController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager) : base(userManager, signInManager)
        {
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Egitim()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Egitim" });
        }


        [Authorize]
        [HttpGet]
        public IActionResult Filoloji()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Filoloji(FilolojiDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FilolojiConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Filoloji" });
        }


        [Authorize]
        [HttpGet]
        public IActionResult Hukuk()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Hukuk(HukukDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(HukukConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Hukuk" });
        }



        [Authorize]
        [HttpGet]
        public IActionResult ilahiyat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult ilahiyat(ilahiyatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ilahiyatConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "ilahiyat" });
        }


        [Authorize]
        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult SosyalBeseri(SosyalBeseriDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SosyalBeseriConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "SosyalBeseri" });
        }




        [Authorize]
        [HttpGet]
        public IActionResult Spor()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Spor(SporDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SporConvert.SporModelToSporEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Spor" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Muhendis()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Muhendis(MuhendislikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MuhendislikConvert.MuhendislikModelToMuhendislikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Muhendis" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Fen()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Fen(FenDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FenConvert.FenModelToFenEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Fen" });
        }




        [Authorize]
        [HttpGet]
        public IActionResult Ziraat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Ziraat(ZiraatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ZiraatConvert.ZiraatModelToZiraatEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Ziraat" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Mimarlik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Mimarlik(MimarlikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MimarlikConvert.MimarlikModelToMimarlikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Mimarlik" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Saglik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Saglik(SaglikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SaglikConvert.SaglikModelToSaglikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Saglik" });
        }



        [Authorize]
        [HttpGet]
        public IActionResult GuzelSanatlar()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("model")) ViewBag.OldData = true;
            return View();
        }

        [Authorize]
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
