using Core.Dtos;
using Core.Models;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class UltraAdminController : BaseController
    {
        public UltraAdminController(UserManager<MyUser> userManager,RoleManager<MyRole> _roleManager) : base(userManager, null, _roleManager)
        {
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
            IQueryable<MyRole> roles =_roleManager.Roles;
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
