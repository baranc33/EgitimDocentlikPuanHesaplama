using WebMvc.Models;
using WebMvc.Models.DocentModels.Bolumler;
using Core.Models;

namespace WebMvc.Models.DocentModels.Models
{
    public class GuzelSanatlarDocentModel
    {
        private decimal SinemaMadde4(int sayi)
        {
            return sayi switch
            {
                var x when x == 0 => 12.5m,
                var x when x == 1 => 6.25m,
                var x when x == 2 => 6.25m,
                var x when x == 3 => 2.5m,
                var x => 1.0m
            };

        }

        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Sinema

        public int[] SinemaIDoktora { get; set; } = default!;
        public int[] SinemaIEtkinlikSayisi { get; set; } = default!;
        public string[] SinemaIHatirlatici { get; set; } = default!;

        public int[] SinemaIIDoktora { get; set; } = default!;
        public int[] SinemaIIEtkinlikSayisi { get; set; } = default!;
        public string[] SinemaIIHatirlatici { get; set; } = default!;



        public int[] SinemaIIIDoktora { get; set; } = default!;
        public int[] SinemaIIIEtkinlikSayisi { get; set; } = default!;
        public string[] SinemaIIIHatirlatici { get; set; } = default!;

        public int[] SinemaIVDoktora { get; set; } = default!;
        public int[] SinemaIVEtkinlikSayisi { get; set; } = default!;
        public int[] SinemaIVTur { get; set; } = default!; /* 0-kitap 12.5  // 1-kitapçeviri 6.25 //    2-makale 6.25  / 3-makale çeviri 2.5*/
        public string[] SinemaIVHatirlatici { get; set; } = default!;



        public int[] SinemaVDoktora { get; set; } = default!;
        public int[] SinemaVEtkinlikSayisi { get; set; } = default!;
        public string[] SinemaVHatirlatici { get; set; } = default!;

        private Sinema SinemaHesapla()
        {
            Sinema model = new();
            decimal Madde1 = 0;
            decimal Madde2 = 0;
            decimal Madde3 = 0;
            decimal Madde4 = 0;
            decimal Madde5 = 0;
            // ekstra değişken oluşturmamak için önce c yi kotnrol edeceğim
            if (SinemaIDoktora.Count() > 1)
            {
                for (int i = 1; i < SinemaIDoktora.Count(); i++)
                {
                    if (SinemaIDoktora[i] == 0 && SinemaIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 20.0m * (decimal)SinemaIEtkinlikSayisi[i];
                        Madde1 += 20 * SinemaIEtkinlikSayisi[i];
                    }
                    else if (SinemaIDoktora[i] == 1 && SinemaIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 20.0m * (decimal)SinemaIEtkinlikSayisi[i];
                        Madde1 += 20 * SinemaIEtkinlikSayisi[i];
                    }
                }
            }

            if (SinemaIIDoktora.Count() > 1)
            {
                for (int i = 1; i < SinemaIIDoktora.Count(); i++)
                {
                    if (SinemaIIDoktora[i] == 0 && SinemaIIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 5.0m * (decimal)SinemaIIEtkinlikSayisi[i];
                        Madde2 += 5.0m * (decimal)SinemaIIEtkinlikSayisi[i];

                    }
                    else if (SinemaIIDoktora[i] == 1 && SinemaIIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 5.0m * (decimal)SinemaIIEtkinlikSayisi[i];
                        Madde2 += 5.0m * (decimal)SinemaIIEtkinlikSayisi[i];
                    }
                }
            }

            if (SinemaIIIDoktora.Count() > 1)
            {
                for (int i = 1; i < SinemaIIIDoktora.Count(); i++)
                {
                    if (SinemaIIIDoktora[i] == 0 && SinemaIIIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 7.5m * (decimal)SinemaIIIEtkinlikSayisi[i];
                        Madde3 += 7.5m * (decimal)SinemaIIIEtkinlikSayisi[i];

                    }
                    else if (SinemaIIIDoktora[i] == 1 && SinemaIIIEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 7.5m * (decimal)SinemaIIIEtkinlikSayisi[i];
                        Madde3 += 7.5m * (decimal)SinemaIIIEtkinlikSayisi[i];
                    }
                }
            }

            if (SinemaIVDoktora.Count() > 1)
            {
                for (int i = 1; i < SinemaIVDoktora.Count(); i++)
                {
                    decimal iValue = SinemaMadde4(SinemaIVTur[i]);
                    if (SinemaIVDoktora[i] == 0 && SinemaIVEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += iValue * (decimal)SinemaIVEtkinlikSayisi[i];
                        Madde4 += iValue * (decimal)SinemaIVEtkinlikSayisi[i];
                    }
                    else if (SinemaIVDoktora[i] == 1 && SinemaIVEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += iValue * (decimal)SinemaIVEtkinlikSayisi[i];
                        Madde4 += iValue * (decimal)SinemaIVEtkinlikSayisi[i];
                    }
                }
            }

            if (SinemaVDoktora.Count() > 1)
            {
                for (int i = 1; i < SinemaVDoktora.Count(); i++)
                {
                    if (SinemaVDoktora[i] == 0 && SinemaVEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 5.0m * (decimal)SinemaVEtkinlikSayisi[i];
                        Madde5 += 5.0m * (decimal)SinemaVEtkinlikSayisi[i];
                    }
                    else if (SinemaVDoktora[i] == 1 && SinemaVEtkinlikSayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 5.0m * (decimal)SinemaVEtkinlikSayisi[i];
                        Madde5 += 5.0m * (decimal)SinemaVEtkinlikSayisi[i];
                    }
                }
            }

            /*
       I- 40
      II -10 
      III 15
      IV-25
      V - 10
      TOPLAM 100  - 90 SI doktora sonrası
       */
            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (Madde1<40|| Madde2 < 10||Madde3<15 || Madde4<25 || Madde5<10 ||model.HamDoktoraSonrasiPuan<90||model.NetPuan<100)
            {
                model.Error = true;
            }




            return model;
        }


      
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

            Sinema Sinema = SinemaHesapla();
            if (Sinema != null)
            {
                message.ToplamNetPuan += Sinema.NetPuan;
                message.ToplamDoktoraOncesi += Sinema.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Sinema.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Sinema.BolumAdi,
                    HamDoktoraOncesi = Sinema.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Sinema.HamDoktoraSonrasiPuan,
                    NetPuan = Sinema.NetPuan,
                    Error = Sinema.Error,
                    ErrorMessage = Sinema.ErrorMessage
                };
                if (Sinema.Error == true) message.Error = true;

                message.NetToplamDoktoraSonrasi += Sinema.HamDoktoraSonrasiPuan;
                
                message.Bolumler.Add(madde);
            }









            if (message.Bolumler != null) message.Colum = message.Bolumler.Count();
            else
            {
                message.Colum = 0;
                message.Error = true;
            }
            return message;
        }

    }
}
