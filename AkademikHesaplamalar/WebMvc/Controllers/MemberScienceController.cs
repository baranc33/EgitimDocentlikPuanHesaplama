using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models.DocentModels.Models;
using System.Text.Json;
using WebMvc.Models.DocentModels;
using WebMvc.Helpers.ConvertToModel;
using Microsoft.AspNetCore.Authorization;
using Core.Serviecs;
using Core.Models.Entities;
using Mapster;

namespace WebMvc.Controllers
{
    public class MemberScienceController : BaseController
    {
        private readonly IEgitimEntityService _egitimEntityService;


        /*
         
         FenEntityService
        FilolojiEntityService
        GuzelSanatlarEntityService
        HukukEntityService
        ilahiyatEntityService
        MessageService
        MimarlikEntityService
        MuhendislikEntityService
        SaglikEntityService
        SosyalEntityService
        SporEntityService
        ZiraatEntityService
         */

        public MemberScienceController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, IEgitimEntityService egitimEntityService) : base(userManager, signInManager)
        {
            _egitimEntityService=egitimEntityService;
        }



        [Authorize]
        [HttpGet]
        public IActionResult Answer(string link)
        {
            ViewBag.link = link;
            Messages? m = JsonSerializer.Deserialize<Messages>(TempData["message"]?.ToString());
            TempData.Remove("message");
            return View(m);
        }







        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Egitim()
        {
            ViewBag.OldData = false;

            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            EgitimEntity entity = _egitimEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {

                TempData["model"] = JsonSerializer.Serialize(entity);

                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Egitim(EgitimDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);

            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            EgitimEntity entity = _egitimEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity == null)
            {
                entity =new();
                entity.MyUserId = user.Id;
                await _egitimEntityService.AddAsync(entity);
            }
            else
            {
                EgitimEntity Newentity = EgitimConvert.EgitimModelToEgitimEntity(model).Adapt<EgitimEntity>();
                Newentity.MyUserId = user.Id;
                Newentity.Id=entity.Id;
                await _egitimEntityService.UpdateAsync(Newentity);
            }


            return RedirectToAction("Answer", "MemberScience", new { link = "Egitim" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Filoloji" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Hukuk" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "ilahiyat" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "SosyalBeseri" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Spor" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Muhendis" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Fen" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Ziraat" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Mimarlik" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "Saglik" });
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
            return RedirectToAction("Answer", "MemberScience", new { link = "GuzelSanatlar" });
        }

    }
}
