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
        private readonly IFenEntityService _fenEntityService;
        private readonly IFilolojiEntityService _filolojiEntityService;
        private readonly IGuzelSanatlarEntityService _guzelSanatlarEntityService;
        private readonly IHukukEntityService _hukukEntityService;




        private readonly IIlahiyatEntityService _ilahiyatEntityService;
        private readonly IMimarlikEntityService _mimarlikEntityService;
        private readonly IMuhendislikEntityService _muhendislikEntityService;
        private readonly ISaglikEntityService _saglikEntityService;
        private readonly ISosyalEntityService _sosyalEntityService;
        private readonly ISporEntityService _sporEntityService;
        private readonly IZiraatEntityService _ziraatEntityService;

        public MemberScienceController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, IEgitimEntityService egitimEntityService, IHukukEntityService hukukEntityService, IGuzelSanatlarEntityService guzelSanatlarEntityService, IFilolojiEntityService filolojiEntityService, IFenEntityService fenEntityService, IIlahiyatEntityService ilahiyatEntityService, IMimarlikEntityService mimarlikEntityService, IMuhendislikEntityService muhendislikEntityService, ISaglikEntityService saglikEntityService, ISosyalEntityService sosyalEntityService, ISporEntityService sporEntityService, IZiraatEntityService ziraatEntityService) : base(userManager, signInManager, null)
        {
            _egitimEntityService =egitimEntityService;
            _hukukEntityService=hukukEntityService;
            _guzelSanatlarEntityService=guzelSanatlarEntityService;
            _filolojiEntityService=filolojiEntityService;
            _fenEntityService=fenEntityService;
            _ilahiyatEntityService=ilahiyatEntityService;
            _mimarlikEntityService=mimarlikEntityService;
            _muhendislikEntityService=muhendislikEntityService;
            _saglikEntityService=saglikEntityService;
            _sosyalEntityService=sosyalEntityService;
            _sporEntityService=sporEntityService;
            _ziraatEntityService=ziraatEntityService;
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

            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            EgitimEntity entity = _egitimEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
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
            MyUser user = CurrentUser;

            EgitimEntity entity = _egitimEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<EgitimEntity>(TempData["model"].ToString());
                await _egitimEntityService.AddAsync(entity);
            }
            else
            {
                EgitimEntity Newentity = EgitimConvert.EgitimModelToEgitimEntity(model).Adapt<EgitimEntity>();
                await _egitimEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Egitim" });
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Fen()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;

            FenEntity entity = _fenEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
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
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            FenEntity entity = _fenEntityService.WhereSingle(x => x.MyUserId==model.MyUserId);


            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<FenEntity>(TempData["model"].ToString());
                await _fenEntityService.AddAsync(entity);
            }
            else
            {
                FenEntity Newentity = FenConvert.FenModelToFenEntity(model).Adapt<FenEntity>();
                await _fenEntityService.UpdateAsync(Newentity);
            }



            return RedirectToAction("Answer", "MemberScience", new { link = "Fen" });



        }



        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Filoloji()
        {

            ViewBag.OldData = false;

            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            FilolojiEntity entity = _filolojiEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
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
            MyUser user = CurrentUser;
            FilolojiEntity entity = _filolojiEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<FilolojiEntity>(TempData["model"].ToString());
                await _filolojiEntityService.AddAsync(entity);
            }
            else
            {
                FilolojiEntity Newentity = FilolojiConvert.FilolojiModelToFilolojiEntity(model).Adapt<FilolojiEntity>();
                await _filolojiEntityService.UpdateAsync(Newentity);
            }


            return RedirectToAction("Answer", "MemberScience", new { link = "Filoloji" });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GuzelSanatlar()
        {
            ViewBag.OldData = false;

            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            GuzelSanatlarEntity entity = _guzelSanatlarEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
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
            MyUser user = CurrentUser;
            GuzelSanatlarEntity entity = _guzelSanatlarEntityService.WhereSingle(x => x.MyUserId==user.Id);


            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<GuzelSanatlarEntity>(TempData["model"].ToString());
                await _guzelSanatlarEntityService.AddAsync(entity);
            }
            else
            {
                GuzelSanatlarEntity Newentity = GuzelSanatlarConvert.GuzelSanatlarModelToGuzelSanatlarEntity(model).Adapt<GuzelSanatlarEntity>();
                await _guzelSanatlarEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "GuzelSanatlar" });
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Hukuk()
        {
            ViewBag.OldData = false;

            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            HukukEntity entity = _hukukEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
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
            MyUser user = CurrentUser;
            HukukEntity entity = _hukukEntityService.WhereSingle(x => x.MyUserId==user.Id);



            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<HukukEntity>(TempData["model"].ToString());
                await _hukukEntityService.AddAsync(entity);
            }
            else
            {
                HukukEntity Newentity = HukukConvert.HukukModelToHukukEntity(model).Adapt<HukukEntity>();
                await _hukukEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Hukuk" });
        }



        [Authorize]
        [HttpGet]
        public IActionResult ilahiyat()
        {
            ViewBag.OldData = false;

            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            ilahiyatEntity entity = _ilahiyatEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ilahiyat(ilahiyatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ilahiyatConvert.ilahiyatModelToilahiyetEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            ilahiyatEntity entity = _ilahiyatEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<ilahiyatEntity>(TempData["model"].ToString());
                await _ilahiyatEntityService.AddAsync(entity);
            }
            else
            {
                ilahiyatEntity Newentity = ilahiyatConvert.ilahiyatModelToilahiyetEntity(model).Adapt<ilahiyatEntity>();
                await _ilahiyatEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "ilahiyat" });
        }


        [Authorize]
        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            SosyalEntity entity = _sosyalEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SosyalBeseri(SosyalBeseriDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SosyalBeseriConvert.SosyalModelToSosyalEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            SosyalEntity entity = _sosyalEntityService.WhereSingle(x => x.MyUserId==user.Id);



            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<SosyalEntity>(TempData["model"].ToString());
                await _sosyalEntityService.AddAsync(entity);
            }
            else
            {
                SosyalEntity Newentity = SosyalBeseriConvert.SosyalModelToSosyalEntity(model).Adapt<SosyalEntity>();
                await _sosyalEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "SosyalBeseri" });
        }




        [Authorize]
        [HttpGet]
        public IActionResult Spor()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            SporEntity entity = _sporEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Spor(SporDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SporConvert.SporModelToSporEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            SporEntity entity = _sporEntityService.WhereSingle(x => x.MyUserId==user.Id);



            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<SporEntity>(TempData["model"].ToString());
                await _sporEntityService.AddAsync(entity);
            }
            else
            {
                SporEntity Newentity = SporConvert.SporModelToSporEntity(model).Adapt<SporEntity>();
                await _sporEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Spor" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Muhendis()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            MuhendislikEntity entity = _muhendislikEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Muhendis(MuhendislikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MuhendislikConvert.MuhendislikModelToMuhendislikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            MuhendislikEntity entity = _muhendislikEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<MuhendislikEntity>(TempData["model"].ToString());
                await _muhendislikEntityService.AddAsync(entity);
            }
            else
            {
                MuhendislikEntity Newentity = MuhendislikConvert.MuhendislikModelToMuhendislikEntity(model).Adapt<MuhendislikEntity>();
                await _muhendislikEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Muhendis" });
        }






        [Authorize]
        [HttpGet]
        public IActionResult Ziraat()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            ZiraatEntity entity = _ziraatEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Ziraat(ZiraatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ZiraatConvert.ZiraatModelToZiraatEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            ZiraatEntity entity = _ziraatEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<ZiraatEntity>(TempData["model"].ToString());
                await _ziraatEntityService.AddAsync(entity);
            }
            else
            {
                ZiraatEntity Newentity = ZiraatConvert.ZiraatModelToZiraatEntity(model).Adapt<ZiraatEntity>();
                await _ziraatEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Ziraat" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Mimarlik()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            MimarlikEntity entity = _mimarlikEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Mimarlik(MimarlikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MimarlikConvert.MimarlikModelToMimarlikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            MimarlikEntity entity = _mimarlikEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<MimarlikEntity>(TempData["model"].ToString());
                await _mimarlikEntityService.AddAsync(entity);
            }
            else
            {
                MimarlikEntity Newentity = MimarlikConvert.MimarlikModelToMimarlikEntity(model).Adapt<MimarlikEntity>();
                await _mimarlikEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Mimarlik" });
        }





        [Authorize]
        [HttpGet]
        public IActionResult Saglik()
        {
            ViewBag.OldData = false;
            MyUser user = CurrentUser;
            ViewBag.MyUserId = user.Id;
            SaglikEntity entity = _saglikEntityService.WhereSingle(x => x.MyUserId==user.Id);
            if (entity!=null)
            {
                ViewBag.Id = entity.Id;
                TempData["model"] = JsonSerializer.Serialize(entity);
                ViewBag.OldData = true;
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Saglik(SaglikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SaglikConvert.SaglikModelToSaglikEntity(model));
            Messages message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            MyUser user = CurrentUser;
            SaglikEntity entity = _saglikEntityService.WhereSingle(x => x.MyUserId==user.Id);

            if (entity == null)
            {
                entity = JsonSerializer.Deserialize<SaglikEntity>(TempData["model"].ToString());
                await _saglikEntityService.AddAsync(entity);
            }
            else
            {
                SaglikEntity Newentity = SaglikConvert.SaglikModelToSaglikEntity(model).Adapt<SaglikEntity>();
                await _saglikEntityService.UpdateAsync(Newentity);
            }
            return RedirectToAction("Answer", "MemberScience", new { link = "Saglik" });
        }




    }
}
