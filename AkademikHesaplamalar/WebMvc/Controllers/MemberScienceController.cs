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
    public class MemberScienceController : Controller
    {
        private readonly IEgitimEntityService _egitimEntityService;
        private readonly IFenEntityService _fenEntityService;
        private readonly IFilolojiEntityService _filolojiEntityService;
        private readonly IGuzelSanatlarEntityService _guzelSanatlarEntityService;
        private readonly IHukukEntityService _hukukEntityService;


        /*
         
         
        
        
        
        ilahiyatEntityService
        MessageService
        MimarlikEntityService
        MuhendislikEntityService
        SaglikEntityService
        SosyalEntityService
        SporEntityService
        ZiraatEntityService
         */
        protected UserManager<MyUser> _userManager { get; }
        public MemberScienceController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, IEgitimEntityService egitimEntityService, IHukukEntityService hukukEntityService, IGuzelSanatlarEntityService guzelSanatlarEntityService, IFilolojiEntityService filolojiEntityService, IFenEntityService fenEntityService)
        {
            _userManager= userManager;
            _egitimEntityService =egitimEntityService;
            _hukukEntityService=hukukEntityService;
            _guzelSanatlarEntityService=guzelSanatlarEntityService;
            _filolojiEntityService=filolojiEntityService;
            _fenEntityService=fenEntityService;
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
            ViewBag.MyUserId = user.Id;
            EgitimEntity entity = _egitimEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();


            ViewBag.OldData = false;
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
                entity = JsonSerializer.Deserialize<EgitimEntity>(TempData["model"].ToString());
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
        public async Task<IActionResult> Fen()
        {
            ViewBag.OldData = false;
            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.MyUserId = user.Id;

            FenEntity entity = _fenEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Fen(FenDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FenConvert.FenModelToFenEntity(model));




            FenEntity entity = _fenEntityService.WhereSingle(x => x.MyUserId==model.MyUserId);
            if (entity == null)
            {

                FenEntity Newentity = JsonSerializer.Deserialize<FenEntity>(TempData["model"].ToString());
                await _fenEntityService.AddAsync(Newentity);
            }
            else
            {
                FenEntity Newentity = FenConvert.FenModelToFenEntity(model).Adapt<FenEntity>();
                Newentity.MyUserId = model.MyUserId;
                Newentity.Id=entity.Id;
                await _fenEntityService.UpdateAsync(Newentity);
            }




            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);


            return RedirectToAction("Answer", "MemberScience", new { link = "Fen" });
        }



        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Filoloji()
        {
            ViewBag.OldData = false;
            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.MyUserId = user.Id;
            FilolojiEntity entity = _filolojiEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Filoloji(FilolojiDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(FilolojiConvert.FilolojiModelToFilolojiEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);

            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            FilolojiEntity entity = _filolojiEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity == null)
            {
                entity =new();
                entity.MyUserId = user.Id;
                await _filolojiEntityService.AddAsync(entity);
            }
            else
            {
                FilolojiEntity Newentity = FilolojiConvert.FilolojiModelToFilolojiEntity(model).Adapt<FilolojiEntity>();
                Newentity.MyUserId = user.Id;
                Newentity.Id=entity.Id;
                await _filolojiEntityService.UpdateAsync(Newentity);
            }


            return RedirectToAction("Answer", "MemberScience", new { link = "Filoloji" });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GuzelSanatlar()
        {
            ViewBag.OldData = false;
            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.MyUserId = user.Id;
            GuzelSanatlarEntity entity = _guzelSanatlarEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GuzelSanatlar(GuzelSanatlarDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(GuzelSanatlarConvert.GuzelSanatlarModelToGuzelSanatlarEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);


            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            GuzelSanatlarEntity entity = _guzelSanatlarEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity == null)
            {
                entity =new();
                entity.MyUserId = user.Id;
                await _guzelSanatlarEntityService.AddAsync(entity);
            }
            else
            {
                GuzelSanatlarEntity Newentity = GuzelSanatlarConvert.GuzelSanatlarModelToGuzelSanatlarEntity(model).Adapt<GuzelSanatlarEntity>();
                Newentity.MyUserId = user.Id;
                Newentity.Id=entity.Id;
                await _guzelSanatlarEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "GuzelSanatlar" });
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Hukuk()
        {
            ViewBag.OldData = false;
            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.MyUserId = user.Id;
            HukukEntity entity = _hukukEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Hukuk(HukukDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(HukukConvert.HukukModelToHukukEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);

            MyUser user = await _userManager.FindByNameAsync(User.Identity?.Name);
            HukukEntity entity = _hukukEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity == null)
            {
                entity =new();
                entity.MyUserId = user.Id;
                await _hukukEntityService.AddAsync(entity);
            }
            else
            {
                HukukEntity Newentity = HukukConvert.HukukModelToHukukEntity(model).Adapt<HukukEntity>();
                Newentity.MyUserId = user.Id;
                Newentity.Id=entity.Id;
                await _hukukEntityService.UpdateAsync(Newentity);
            }
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




    }
}
