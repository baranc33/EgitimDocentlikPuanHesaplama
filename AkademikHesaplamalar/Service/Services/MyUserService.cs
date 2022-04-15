using Core;
using Core.Dtos;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;
using Microsoft.AspNetCore.Identity;

namespace Service.Services
{
    public class MyUserService : IMyUserService
    {
        protected UserManager<MyUser> _userManager { get; }
        protected SignInManager<MyUser> _signInManager { get; }

        protected RoleManager<MyRole>? _roleManager { get; }

        // kullanııcıyı bulma

        public MyUserService(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager, RoleManager<MyRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }


        public async Task<IdentityResult> CreateUser(UserDto model)
        {
            MyUser user = new MyUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                Resim= model.Password
            };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            return result;
        }



        public async Task<string> Login(LoginDto model)
        {
            MyUser user = new();
            if (model.UserName.Contains("@"))
                user = await _userManager.FindByEmailAsync(model.UserName);
            else
                user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                if (await _userManager.IsLockedOutAsync(user)) // true dönerse kitlidir
                {
                    return "Hesabınız Bir Süreliğine kitlenmiştir bir süre sonra tekrar deneyiniz";
                }
                else
                {
                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(user);
                        return "Success";
                    }
                    else 
                    {
                        await _userManager.AccessFailedAsync(user);// hhatalı girişi 1 arttır
                        int fail = await _userManager.GetAccessFailedCountAsync(user);// hatalı girişleri getir

                        if (fail == 3)
                        {// 3 başarısız giriş yapmak
                            await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(5)));
                            return "Hesabınız 5 dk boyunca kitlendi.";
                        }
                        // hatalı giriş mesajı
                        return $"{fail} Hatalı Giriş Yaptınız";

                    }
                }
            }
            else
            {
                return "Geçersiz kullanıcı adı veya  şifresi";
            }
        }
    }
}
