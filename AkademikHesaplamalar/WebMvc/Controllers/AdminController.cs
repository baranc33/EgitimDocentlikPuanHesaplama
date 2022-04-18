using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Core.Serviecs;

namespace WebMvc.Controllers
{
    public class AdminController : BaseController
    {

        private readonly IMessageService _myMessageService;
        private readonly IAdminMemberService _adminMemberService;

        public AdminController(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager, IMessageService myMessageService, IAdminMemberService adminMemberService) : base(userManager, null, roleManager)
        {
            _myMessageService=myMessageService;
            _adminMemberService=adminMemberService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }



        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult UpdateAdminMember()
        {
            MyUser user = CurrentUser;
            AdminMember admin =  _adminMemberService.WhereSingle(x=>x.MyUserId==user.Id);
            return View(admin);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateAdminMember(AdminMember member, IFormFile userPicture)
        {
            AdminMember oldData = _adminMemberService.WhereSingle(x => x.Id==member.Id);
            string oldPictrueName = oldData.Image;
            if (userPicture != null && userPicture.Length > 0)
            {// bir path ismi oluşturuyoruz
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(userPicture.FileName);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await userPicture.CopyToAsync(stream);

                    member.Image= fileName;
                }

                member.Image= fileName;
                // burdan eski resmi silcem 13. indexten alıyorumki user picture yazısını iptal edeyim
                if (oldPictrueName!=null && oldPictrueName.Length>5)
                {// hiç resmi yoksa diye kontrol ediyorum
                    var deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", oldPictrueName);
                    FileInfo fi = new FileInfo(deletePath);
                    System.IO.File.Delete(deletePath);
                    fi.Delete();
                }
            }


            await _adminMemberService.UpdateAsync(member);
            ViewBag.success=true;

            return View(member);
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Message()
        {
            IQueryable<MyMessage> list = _myMessageService.Where(x => x.Description.Length>1).OrderByDescending(x => x.Id);

            return View(list);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MessageUpdate(int id)
        {
            MyMessage message= await _myMessageService.GetByIdAsync(id);

            return View(message);
        }//

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MessageDelete(int id)
        {
            MyMessage message = await _myMessageService.GetByIdAsync(id);

            await _myMessageService.RemoveAsync(message);

            return RedirectToAction("Message");
        }//MessageDelete
    }
}
