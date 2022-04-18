using Core.smtp;
using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Core.Serviecs;
using Core.Dtos;

namespace WebMvc.Controllers
{
    public class HomeController : BaseController
    {

        private readonly IMyUserService _myUserService;
        private readonly IAdminMemberService _adminMemberService;
        private readonly IMyContactService _myContactService;
        private readonly IMessageService _myMessageService;

        public HomeController(UserManager<MyUser> _userManager, SignInManager<MyUser> _signInManager, IMyUserService myUserService, IAdminMemberService adminMemberService, IMessageService myMessageService, IMyContactService myContactService) : base(_userManager, _signInManager)
        {
            _myUserService=myUserService;
            _adminMemberService=adminMemberService;
            _myMessageService=myMessageService;
            _myContactService=myContactService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "MemberHome");
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserDto model)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _myUserService.CreateUser(model);
                if (result.Succeeded)
                {
                    TempData["SignMessage"] ="Kayıt işleminiz Başarıyla gerçekleştirildi";
                    return RedirectToAction("Login");
                }
                else
                    AddModelError(result);
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            TempData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                string result = await _myUserService.Login(model);
                if (result!="Success")
                    ModelState.AddModelError("", result);
                else
                {
                    if (TempData["ReturnUrl"] != null)
                        return Redirect(TempData["ReturnUrl"].ToString());

                    return RedirectToAction("Index", "MemberHome");
                }
            }
            else
                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya  şifresi");

            return View(model);
        }
        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ResetPassword()
        {
            TempData["durum"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(PasswordResetDto passwordResetViewModel)
        {
            if (TempData["durum"] == null)
            {
                MyUser user = _userManager.FindByEmailAsync(passwordResetViewModel.Email).Result;
                //  kullanıcı doğru varmı bakıyoruz
                if (user != null)
                {

                    string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;

                    // bir link oluşturcaz mailde tıkladığında gideceği yer
                    string passwordResetLink = Url.Action("ResetPasswordConfirm", "Home", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);



                    PasswordReset.PasswordResetSendEmail(passwordResetLink, user.Email);
                    TempData["passwordGmail"] = "Mail Adresinize Yenilemek için bir posta gönderdik Şifrenizi yenilemek için oraya tıklayınız";

                    ViewBag.status = "success";
                    TempData["durum"] = true.ToString();
                    return RedirectToAction("ResetPasswordConfirm");
                }
                else
                {
                    // email hatalı ise
                    ModelState.AddModelError("", "Sistemde kayıtlı email adresi bulunamamıştır.");
                }
                return View(passwordResetViewModel);
            }
            else
            {
                return RedirectToAction("ResetPassword");
            }
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirm(string userId, string token)
        {

            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();
        }


        [HttpPost]// bind işlemi ile sadece şifreyi alıyoruz. Email gerekmediğini belirtiyoruz
        public async Task<IActionResult> ResetPasswordConfirm([Bind("PasswordNew")] PasswordResetViewModel model)
        {

            string userId = TempData["userId"].ToString();
            string token = TempData["token"].ToString();

            MyUser user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {//bu oluşturduğumuz token içersinde securityStamp te bulunmaktadır
             // şifreyi değiştirdikten sonra linkin geçersiz olması için securityStamp kısmını değiştirlmeliyiz
                IdentityResult result = await _userManager.ResetPasswordAsync(user, token, model.PasswordNew);

                if (result.Succeeded)
                {// securityStamp dğeiştireceğiz
                    await _userManager.UpdateSecurityStampAsync(user);
                    TempData["passwordResetInfo"] = "Şifreniz Başarıyla yenilenmmiştir. Yeni şifreniz ile giriş yapabilirsiniz.";
                    // bu mesajı login kısmında gösteriyorum    
                    return RedirectToAction("Login");
                }
                else
                {

                    AddModelError(result);
                    //TempData["passwordResetInfo"] = "Şifreniz Başarıyla yenilenmmiştir. Yeni şifreniz ile giriş yapabilirsiniz.";

                }

            }
            // eğer hatalı işlem olursa tempdata siliniyor o yüzden dolayı  tekrardan yolluyorum
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View(model);
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
    public async Task<IActionResult> Contact(MyMessage entity)
    {
        await _myMessageService.AddAsync(entity);

        ViewBag.Message="Mesajınız Tarafımıza iletilmiştir Teşekkürler";
        return View();
    }

}
}
