using System.Net.Mail;
using System.Net;

namespace Core.smtp
{
    public static class PasswordReset
    {

        public static void PasswordResetSendEmail(string link, string email)
        {
            // mail göndere bilmek önce mail açıkken güvenliğini izin vermeliyiz
            //https://myaccount.google.com/lesssecureapps?pli=1&rapt=AEjHL4NdWDCEVH_yZNeXLR5Ca9EaqYQ3lgEYU5tyIERrr49koSOULHvyneHuKOsV2nSfPj0zkSoesKO5LOunNMzbJCgxSOSG2Q

            try
            {
                //MailMessage kütüphanesinden bir instance oluşturuyoruz.
                MailMessage mail = new MailMessage();
                //Mesaj içeriğinde html ifadelere izin veriyoruz.
                mail.IsBodyHtml = true;
                //Bu kısım mail'in kime gideceğidir.Kendi adresimi yazdım.
                mail.To.Add(email);
                //Burası ise kimin göndereceğidir.Kim gönderecek?
                mail.From = new MailAddress("docenthesapla@gmail.com", "Akademik Hesaplamalar");
                //Gelen mailin konusu
                mail.Subject = "Şifre Sıfırlama isteği";
                //mail.Body += "<h4 class='text-center'>Eğer Bu isteği siz göndermediyseniz ciddiye almayınız.</h4><hr>";
                //mail.Body += "<div class='col-md-6 offset-3 bg-primary text-white mt-5'><p class='text-warning'></p>";
                mail.Body = "<center><h1> Akademik Hesaplamalar sitemize şifre yenilenme isteğinde bulunuldu </h1></center>";
                mail.Body += "<center style='border-radius: 40px;padding-top:30px;padding-bottom:30px;margin-left: 10%;margin-right: 10%;background-color: rgba(29, 26, 191, 0.834);'>";
                mail.Body += "<h2 style='color:white'> Saygı Değer Kullanıcımız </h2><hr><div>";
                mail.Body += $"<p style='color:white'> Az önce wwww.akademikhesaplamalar,com sitesimize.  Mail adresiz adına şifre Sıfırlama isteğinde bulunuldu</p>";
                mail.Body += "<p style='color:yellow' > Adres size ait değilse veya işlem tarafınızca gerçekleştirilmediyse dikkate almayınız </p>";
                mail.Body += $"<a style='color:red;text-decoration:none;font-size:20px;' href='{link}' > Şifrenizi Yenilemek için tıklayınız.</a></div> </center> ";
                mail.Body += $"<p> Bu istek sürekli tekrar ediyor ve sizin değilse sitemizin iletişim kısmından bize bildiriniz.</p>";
                mail.Body += "<a href='www.akademikhesaplamalar.com' style='text-decoration:none;'> wwww.akademikhesaplamalar.com >></a>";
                mail.IsBodyHtml = true;
                // smptp clientiını host firmamızdan öğreneceğiz
                SmtpClient smtp = new SmtpClient();
                //Burada maili gönderen kişinin mail adresi ve şifresi alınıyor.
                smtp.Credentials = new System.Net.NetworkCredential("docenthesapla@gmail.com", "hesaplaDocent33");
                //Hangi portu kullanacağımızı yazıyoruz.
                smtp.Port = 587;
                //Hangi mail adresini kullanacağızı seçiyoruz.
                smtp.Host = "smtp.gmail.com";
                //Ssl güvenlik protokolünü aktifleştiriyoruz.
                smtp.EnableSsl = true;
                //Maili gönderiyoruz.
                smtp.Send(mail);

            }
            catch (Exception)
            {
                throw;
            }


        }

         

    }
}
