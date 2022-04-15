using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;

namespace WebMvc.Helpers.Validaton
{
    public class CustomUserValidator : IUserValidator<MyUser>
    {
        List<IdentityError> errors = new List<IdentityError>();
        public Task<IdentityResult> ValidateAsync(UserManager<MyUser> manager, MyUser user)
        {// burda user name müdehale edebiliriz fakat bu classı
            // diğer stunlar içinde aynı hizmeti kulllanabiliriz fakat Gerek YokSuan
            // kullanıcı Adı girerken Sayisal Karakterle Başlamasın
            string[] Digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            // contains kullanabilirdik fakat biraz farklı kod ekliyelim

            foreach (var item in Digits)
            {
                if (user.UserName[0].ToString() == item)
                {
                    errors.Add(new IdentityError()
                    {
                        Code = "UserNameContainsFirstLetterDigitContains",// burdaki isimlerdirme Tamamen Bize Bağlı
                        Description = "Kullanıcı Adınızın Başında Sayı Olamaz"
                    });
                }
            }

            if (errors.Count == 0)// hata yoksa
            {
                return Task.FromResult(IdentityResult.Success); // başarılı
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
        }
    }

}
