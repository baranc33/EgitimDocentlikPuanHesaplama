using DocentlikPuanHesaplama.IdentityModel;

namespace DocentlikPuanHesaplama.Models.DocentModels
{
    public class GuzelSanatlarDocentModel
    {
        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Sinema

        public int[] SinemaIDoktora { get; set; } = default!;
        public int[] SinemaIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIHatirlatici { get; set; }



        public int[] SinemaIIDoktora { get; set; } = default!;
        public int[] SinemaIIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIIHatirlatici { get; set; }



        public int[] SinemaIIIDoktora { get; set; } = default!;
        public int[] SinemaIIIEtkinlikSayisi { get; set; } = default!;
        public string? SinemaIIIHatirlatici { get; set; }


        public int[] SinemaIVDoktora { get; set; } = default!;
        public int[] SinemaIVEtkinlikSayisi { get; set; } = default!;
        public int[] SinemaIVTur { get; set; } = default!; /* 0-kitap 12.5  // 1-kitapçeviri 6.25 //    2-makale 6.25  / 3-makale çeviri 6.25*/
        public string? SinemaIVHatirlatici { get; set; }



        public int[] SinemaVDoktora { get; set; } = default!;
        public int[] SinemaVEtkinlikSayisi { get; set; } = default!;
        public string? SinemaVHatirlatici { get; set; }




        /*
         I- 40
        III 15
        IV-25
        II -10 
        V - 10
        TOPLAM 100  - 90 SI doktora sonrası
         */
        #endregion






        #region Muzik
        /*Bütün şartlar zorunludur*/


        #endregion



        public Messages Hesapla()
        {
            Messages message = new();
            message.Error = false;
            message.NetToplamDoktoraSonrasi = 0;
            message.ToplamDoktoraOncesi = 0;
            message.ToplamDoktoraSonrasi = 0;
             

            return message;
        }

    }
}
