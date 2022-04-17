using Core.Dtos;
using Core.Models;
using Core.Serviecs;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class UltraAdminController : BaseController
    {
        private readonly IMyUserService _myUserService;
        private readonly IAdminMemberService _adminMemberService;

        public UltraAdminController(UserManager<MyUser> userManager, RoleManager<MyRole> _roleManager, IMyUserService myUserService, IAdminMemberService adminMemberService) : base(userManager, null, _roleManager)
        {
            _myUserService=myUserService;
            _adminMemberService=adminMemberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Claims()
        {
            return View(User.Claims.ToList());
        }

        public IActionResult RoleCreate()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View(_userManager.Users.ToList());
        }

        public IActionResult Roles()
        {
            return View(_roleManager.Roles.ToList());
        }

        [HttpPost]
        public IActionResult RoleCreate(RoleDto roleViewModel)
        {
            // önce Role Oluşturuyoruz
            MyRole role = new MyRole();
            role.Name = roleViewModel.Name;
            // rol oluşturma
            IdentityResult result = _roleManager.CreateAsync(role).Result;
            // işlem başarılıysa standart işlemler
            if (result.Succeeded)
                return RedirectToAction("Roles");
            else
                AddModelError(result);

            return View(roleViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> AdminMember()
        {
            IEnumerable<AdminMember> members = await _adminMemberService.GetAllAsync();
            List<AdminMemberDto> adminMembers = new();
            foreach (var item in members)
            {
                AdminMemberDto dto = new()
                {
                    Degree = item.Degree,
                    Description = item.Description,
                    Facebook = item.Facebook,
                    FullName = item.FullName,
                    Github = item.Github,
                    Id = item.Id,
                    IdRow = item.IdRow,
                    Instegram = item.Instegram,
                    Linkedin = item.Linkedin,
                    MailAdres = item.MailAdres,
                    MailExtension = item.MailExtension,
                    MyUserId = item.MyUserId,
                    WebSiteUrl = item.WebSiteUrl,
                    İmage=item.Image
                };

                MyUser Dtouser = await _userManager.FindByIdAsync(item.MyUserId);
                dto.UserEmail = Dtouser.Email;
                dto.UserName = Dtouser.UserName;

                adminMembers.Add(dto);
            }

            return View(adminMembers);
        }


        [HttpGet]
        public async Task<IActionResult> UpdateAdminMember(int Id)
        {

            AdminMember admin = await _adminMemberService.GetByIdAsync(Id);
            return View(admin);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdminMember(AdminMember member)
        {
            ViewBag.success=true;

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteAdminMember(int Id)
        {
            AdminMember admin = await _adminMemberService.GetByIdAsync(Id);
            await _adminMemberService.RemoveAsync(admin);
            return RedirectToAction("AdminMember");
        }



        public IActionResult RoleDelete(string id)
        {// klasik silme işlemi id den buluyoru sonra id varsa işlem yapıyoruz
            MyRole role = _roleManager.FindByIdAsync(id).Result;
            if (role != null)
            {// silme işlemi yapıyoruz 
                IdentityResult result = _roleManager.DeleteAsync(role).Result;
            }
            return RedirectToAction("Roles");
        }

        public IActionResult RoleUpdate(string id)
        {
            MyRole role = _roleManager.FindByIdAsync(id).Result;

            if (role != null)
            {
                return View(role.Adapt<RoleDto>());
            }

            return RedirectToAction("Roles");
        }



        // role atama
        [HttpPost]
        public IActionResult RoleUpdate(RoleDto roleViewModel)
        {
            MyRole role = _roleManager.FindByIdAsync(roleViewModel.Id).Result;

            if (role != null)
            {
                role.Name = roleViewModel.Name;
                IdentityResult result = _roleManager.UpdateAsync(role).Result;

                if (result.Succeeded)
                    return RedirectToAction("Roles");
                else
                    AddModelError(result);
            }
            else
                ModelState.AddModelError("", "Güncelleme işlemi başarısız oldu.");

            return View(roleViewModel);
        }

        // role atama
        public IActionResult RoleAssign(string id)
        {
            // üyenin id sini alıyoruz ve temp dataya atıyoruz
            TempData["userId"] = id;
            // userı getiriyoruz
            MyUser user = _userManager.FindByIdAsync(id).Result;
            // içerde kullanmak için username ide alıyoruz
            ViewBag.userName = user.UserName;
            // rolleri listeliyoruz
            IQueryable<MyRole> roles = _roleManager.Roles;
            // userın rollerini getiriyoruz list<stringe> cast ediyoruz
            List<string> userroles = _userManager.GetRolesAsync(user).Result as List<string>;
            // yeni bi role asignview model oluşturuyoruz
            List<RoleAssignDto> roleAssignViewModels = new List<RoleAssignDto>();

            // rolleri tek tek dönüyoruz ve role assigne atıyoruz 
            // hangi roller varsa true çek ediyoruzki check boxta  chked yapmak için
            foreach (var role in roles)
            {
                RoleAssignDto r = new RoleAssignDto();
                r.RoleId = role.Id;
                r.RoleName = role.Name;
                if (userroles.Contains(role.Name))
                {
                    r.Exist = true;
                }
                else
                {
                    r.Exist = false;
                }
                roleAssignViewModels.Add(r);
            }

            return View(roleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> RoleAssign(List<RoleAssignDto> roleAssignViewModels)
        {
            // userı buluyoruz
            MyUser user = _userManager.FindByIdAsync(TempData["userId"].ToString()).Result;
            // her role için tek tek işlem yapıoruz 
            // ya ekliyoruz eklemiyorsak siliyoruz
            foreach (var item in roleAssignViewModels)
            {
                if (item.Exist)

                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                    AdminMember adminMember = new AdminMember()
                    {
                        MyUserId=user.Id
                    };
                    bool result = await _adminMemberService.AnyAsync(x => x.MyUserId==user.Id);
                    if (!result)
                        await _adminMemberService.AddAsync(adminMember);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }

            return RedirectToAction("Users");
        }


    }
}
