using AkademikHesaplamalar.Helpers.smtp;
using AkademikHesaplamalar.Models;
using AkademikHesaplamalar.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademikHesaplamalar.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<MyUser> _userManager, SignInManager<MyUser> _signInManager) : base(_userManager, _signInManager)
        {
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Member");
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                MyUser user = new MyUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Resim= model.Password
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    AddModelError(result);
                }

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
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                MyUser user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    if (await _userManager.IsLockedOutAsync(user)) // true dönerse kitlidir
                    {
                        ModelState.AddModelError("", "Hesabınız Bir Süreliğine kitlenmiştir bir süre sonra tekrar deneyiniz");
                    }
                    else
                    {

                        // önce kayıtlı coockileri siliyoruz
                        await _signInManager.SignOutAsync();

                        // 1. true/false program.cs te belirttiğimiz coockie ömrünü aktif eder
                        // 2. true/false başarısız girişlerde kulanıcı kitleme
                        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                        //if (result.IsNotAllowed)//kullanıcı kitliyken doğru giriş yaparsa
                        //if (result.Succeeded)// işlem başarılımı
                        //if (result.IsLockedOut)//kullanıcı kitlimi değilmi
                        //if (result.RequiresTwoFactor)// iki faktörlü koruma açıkmı?
                        if (result.Succeeded)
                        {
                            await _userManager.ResetAccessFailedCountAsync(user);
                            if (TempData["ReturnUrl"] != null)
                            {
                                return Redirect(TempData["ReturnUrl"].ToString());
                            }
                            return RedirectToAction("Index", "Member");
                        }
                        else
                        {

                            await _userManager.AccessFailedAsync(user);// hhatalı girişi 1 arttır
                            int fail = await _userManager.GetAccessFailedCountAsync(user);// hatalı girişleri getir

                            if (fail == 3)
                            {// 3 başarısız giriş yapmak
                                await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(5)));
                                ModelState.AddModelError("", "Hesabınız 5 dk boyunca kitlendi.");
                            }
                            // hatalı giriş mesajı
                            ModelState.AddModelError("", $"{fail} Hatalı Giriş Yaptınız");

                        }
                    }



                }
                else
                {
                    // kullanıcı yoksa Email inputu hedefli bir mesaj yolliyalım
                    ModelState.AddModelError(nameof(LoginViewModel.UserName), "Geçersiz kullanıcı adı veya  şifresi");
                }
            }






            return View(model);
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            // post kısmında temp data kullanacağımız için burda null a çekiyoruz
            TempData["durum"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(PasswordResetViewModel passwordResetViewModel)
        {
            if (TempData["durum"] == null)
            {
                MyUser user = _userManager.FindByEmailAsync(passwordResetViewModel.Email).Result;
                //  kullanıcı doğru varmı bakıyoruz
                if (user != null)
                {
                    //user manager sınıfından bir token oluşturuyoruz
                    // bu tokenı maile ile yollicazki doğrulama işleminde doğru mail adresinden 
                    // dönüş olduğunu onaylamak için bu tokenı oluşturmak için program.cs te service eklemeliyiz
                    // ıdentity altına .AddDefaultTokenProviders();
                    //
                    string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;

                    // bir link oluşturcaz mailde tıkladığında gideceği yer
                    string passwordResetLink = Url.Action("ResetPasswordConfirm", "Home", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);

                    //  www.bıdıbıdı.com/Home/ResetPasswordConfirm?userId=sdjfsjf&token=dfjkdjfdjf

                    PasswordReset.PasswordResetSendEmail(passwordResetLink, user.Email);

                    // mail gönderildimi diğe bilgi ekliyoruz
                    ViewBag.status = "success";
                    TempData["durum"] = true.ToString();
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
            // gelen bilgileri tempdataya yazıyoruz post kısmından erişebilmek için
            // aynı zamanda bu şifre ve şifre tekrarı gibi seçenek yaparsak
            // bu bilgileri tekrar tekrar göndermek yerine temp datadan çekeriiz
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
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }
    }
}
