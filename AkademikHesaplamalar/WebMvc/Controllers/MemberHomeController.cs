using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Core.Serviecs;
using Core.Dtos;
using Mapster;

namespace WebMvc.Controllers
{

 
    public class MemberHomeController : BaseController
    {
        private readonly IMyContactService _myContactService;
        private readonly IMessageService _myMessageService;
        private readonly IAdminMemberService _adminMemberService;
        public MemberHomeController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, IMyContactService myContactService, IMessageService myMessageService, IAdminMemberService adminMemberService) : base(userManager, signInManager)
        {
            _myContactService=myContactService;
            _myMessageService=myMessageService;
            _adminMemberService=adminMemberService;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            IList<string> Roles = await _userManager.GetRolesAsync(CurrentUser);
            if (Roles.Contains("UltraAdmin"))
                return RedirectToAction("Index", "UltraAdmin");
            else if (Roles.Contains("Admin"))
                return RedirectToAction("Index", "Admin");

            return View();
        }










        public IActionResult About()
        {
            IQueryable<AdminMember> admin = _adminMemberService.Where(x => x.Id>=0).OrderBy(c => c.IdRow);
            return View(admin);
        }


        public async Task<IActionResult> Contact()
        {
            IEnumerable<MyContact> list = await _myContactService.GetAllAsync();
            return View(list.FirstOrDefault());
        }


        [HttpPost]
        public async Task<IActionResult> Contact(MyMessageDto entity)
        {
            IEnumerable<MyContact> list = await _myContactService.GetAllAsync();

            if (ModelState.IsValid)
            {
                await _myMessageService.AddAsync(entity.Adapt<MyMessage>());
                ViewBag.Message="Mesajınız Tarafımıza iletilmiştir Teşekkürler";
            }
            else
            {
                ViewBag.MyError="Gerekli Alanları Doldurmadınız Mesajınız Tarafımıza iletilemedi :( ";
                ModelState.AddModelError("", "Lütfen Bütün Alanları Doldurunuz");
            }
            return View(list.FirstOrDefault());

        }
    }
}
