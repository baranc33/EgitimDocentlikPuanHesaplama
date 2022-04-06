using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.Models.Bolumler;

namespace DocentlikPuanHesaplama.Models.DocentModels
{
    public class ilahiyatDocentModel
    {

        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region UluslarArasi
        public int[] UluslarArasiAdoktora { get; set; } = default!;
        public int[] UluslarArasiAmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiAyazarsayisi { get; set; } = default!;
        public string[] UluslarArasiAhatirlatici { get; set; } = default!;

        public int[] UluslarArasiBdoktora { get; set; } = default!;
        public int[] UluslarArasiBmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiByazarsayisi { get; set; } = default!;
        public string[] UluslarArasiBhatirlatici { get; set; } = default!;

        public int[] UluslarArasiCdoktora { get; set; } = default!;
        public int[] UluslarArasiCmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiCyazarsayisi { get; set; } = default!;
        public string[] UluslarArasiChatirlatici { get; set; } = default!;


        private UluslarArasi UluslarArasiHesapla()
        {
            UluslarArasi model = new();
            if (UluslarArasiAdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiAdoktora.Count(); i++)
                {
                   
                    if (UluslarArasiAdoktora[i] == 0 && UluslarArasiAmakalesayisi[i] > 0 && UluslarArasiAyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (20 * UluslarArasiAmakalesayisi[i]) / (decimal)UluslarArasiAyazarsayisi[i];
                    }
                    else if (UluslarArasiAdoktora[i] == 1 && UluslarArasiAmakalesayisi[i] > 0 && UluslarArasiAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * UluslarArasiAmakalesayisi[i]) / (decimal)UluslarArasiAyazarsayisi[i];
                    }
                }

            }
            if (UluslarArasiBdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiBdoktora.Count(); i++)
                {
                   
                    if (UluslarArasiBdoktora[i] == 0 && UluslarArasiBmakalesayisi[i] > 0 && UluslarArasiByazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (10 * UluslarArasiBmakalesayisi[i]) / (decimal)UluslarArasiByazarsayisi[i];
                    }
                    else if (UluslarArasiBdoktora[i] == 1 && UluslarArasiBmakalesayisi[i] > 0 && UluslarArasiByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (10 * UluslarArasiBmakalesayisi[i]) / (decimal)UluslarArasiByazarsayisi[i];
                    }
                }

            }
            if (UluslarArasiCdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiCdoktora.Count(); i++)
                {
                   
                    if (UluslarArasiCdoktora[i] == 0 && UluslarArasiCmakalesayisi[i] > 0 && UluslarArasiCyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (5 * UluslarArasiCmakalesayisi[i]) / (decimal)UluslarArasiCyazarsayisi[i];
                    }
                    else if (UluslarArasiCdoktora[i] == 1 && UluslarArasiCmakalesayisi[i] > 0 && UluslarArasiCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (5 * UluslarArasiCmakalesayisi[i]) / (decimal)UluslarArasiCyazarsayisi[i];
                    }
                }
            }
            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            return model;
        }

        #endregion


        #region Ulusal
        public int[] UlusalAdoktora { get; set; } = default!;
        public int[] UlusalAmakalesayisi { get; set; } = default!;
        public int[] UlusalAyazarsayisi { get; set; } = default!;
        public string[] UlusalAhatirlatici { get; set; } = default!;


        public int[] UlusalBdoktora { get; set; } = default!;
        public int[] UlusalBmakalesayisi { get; set; } = default!;
        public int[] UlusalByazarsayisi { get; set; } = default!;
        public string[] UlusalBhatirlatici { get; set; } = default!;
        private Ulusal UlusalHesapla()
        {
            Ulusal model = new();
            int sart = 0;
            int sartB = 0;
            if (UlusalAdoktora.Count() > 1)
            {
                for (int i = 1; i < UlusalAdoktora.Count(); i++)
                {
                    if (UlusalAdoktora[i] == 0 && UlusalAmakalesayisi[i] > 0 && UlusalAyazarsayisi[i] > 0)
                    {
                        sart += UlusalAmakalesayisi[i];
                        model.HamDoktoraOncesiPuan += (10 * UlusalAmakalesayisi[i]) / (decimal)UlusalAyazarsayisi[i];
                    }
                    else if (UlusalAdoktora[i] == 1 && UlusalAmakalesayisi[i] > 0 && UlusalAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (10 * UlusalAmakalesayisi[i]) / (decimal)UlusalAyazarsayisi[i];
                        sart += UlusalAmakalesayisi[i];
                    }
                }

            }
            if (UlusalBdoktora.Count() > 1)
            {
                for (int i = 1; i < UlusalBdoktora.Count(); i++)
                {
                    if (UlusalBdoktora[i] == 0 && UlusalBmakalesayisi[i] > 0 && UlusalByazarsayisi[i] > 0)
                    {
                        sartB += UlusalBmakalesayisi[i];
                        model.HamDoktoraOncesiPuan += (5 * UlusalBmakalesayisi[i]) / (decimal)UlusalByazarsayisi[i];
                    }
                    else if (UlusalBdoktora[i] == 1 && UlusalBmakalesayisi[i] > 0 && UlusalByazarsayisi[i] > 0)
                    {
                        sartB += UlusalBmakalesayisi[i];
                        model.HamDoktoraSonrasiPuan += (5 * UlusalBmakalesayisi[i]) / (decimal)UlusalByazarsayisi[i];
                    }
                }

            }

            if (sart + sartB < 3) model.Error = true;

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;


            model.ErrorMessage = "2. Ulusal Makale maddesinin a veya b bendi kapsamında en az üç yayın yapmak zorunludurk";
            return model;
        }
        #endregion


        #region Yayin
        public int[] YayinAdoktora { get; set; } = default!;
        public int[] YayinAkitap { get; set; } = default!;
        public int[] YayinAyazarsayisi { get; set; } = default!;
        public string[] YayinAhatirlatici { get; set; } = default!;

        public int[] YayinBdoktora { get; set; } = default!;
        public int[] YayinBbolumSayisi { get; set; } = default!;
        public int[] YayinByazarsayisi { get; set; } = default!;
        public string[] YayinBhatirlatici { get; set; } = default!;

        public int[] YayinCdoktora { get; set; } = default!;
        public int[] YayinCkitap { get; set; } = default!;
        public int[] YayinCyazarsayisi { get; set; } = default!;
        public string[] YayinChatirlatici { get; set; } = default!;

        public int[] YayinDdoktora { get; set; } = default!;
        public int[] YayinDbolumSayisi { get; set; } = default!;
        public int[] YayinDyazarsayisi { get; set; } = default!;
        public string[] YayinDhatirlatici { get; set; } = default!;

        public int[] YayinEdoktora { get; set; } = default!;
        public int[] YayinEmakalesayisi { get; set; } = default!;
        public int[] YayinEyazarsayisi { get; set; } = default!;
        public string[] YayinEhatirlatici { get; set; } = default!;

        public int[] YayinFdoktora { get; set; } = default!;
        public int[] YayinFmakalesayisi { get; set; } = default!;
        public int[] YayinFyazarsayisi { get; set; } = default!;
        public string[] YayinFhatirlatici { get; set; } = default!;

        public int[] YayinGdoktora { get; set; } = default!;
        public int[] YayinGmakalesayisi { get; set; } = default!;
        public int[] YayinGyazarsayisi { get; set; } = default!;
        public string[] YayinGhatirlatici { get; set; } = default!;
        private Yayin YayinHesapla()
        {
            Yayin model = new();
            if (YayinAdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinAdoktora.Count(); i++)
                {
                    if (YayinAdoktora[i] == 0 && YayinAkitap[i] > 0 && YayinAyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (10 * YayinAkitap[i]) / (decimal)YayinAyazarsayisi[i];
                    }
                    else if (YayinAdoktora[i] == 1 && YayinAkitap[i] > 0 && YayinAyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (10 * YayinAkitap[i]) / (decimal)YayinAyazarsayisi[i];
                    }
                }
            }
            if (YayinBdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinBdoktora.Count(); i++)
                {
                    if (YayinBdoktora[i] == 0 && YayinBbolumSayisi[i] > 0 && YayinByazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (8 * YayinBbolumSayisi[i]) / (decimal)YayinByazarsayisi[i];
                    }
                    else if (YayinBdoktora[i] == 1 && YayinBbolumSayisi[i] > 0 && YayinByazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (8 * YayinBbolumSayisi[i]) / (decimal)YayinByazarsayisi[i];
                    }
                }

            }
            if (YayinCdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinCdoktora.Count(); i++)
                {
                    if (YayinCdoktora[i] == 0 && YayinCkitap[i] > 0 && YayinCyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (10 * YayinCkitap[i]) / (decimal)YayinCyazarsayisi[i];
                    }
                    else if (YayinCdoktora[i] == 1 && YayinCkitap[i] > 0 && YayinCyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (10 * YayinCkitap[i]) / (decimal)YayinCyazarsayisi[i];
                    }
                }

            }

            if (YayinDdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinDdoktora.Count(); i++)
                {
                    if (YayinDdoktora[i] == 0 && YayinDbolumSayisi[i] > 0 && YayinDyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (4 * YayinDbolumSayisi[i]) / (decimal)YayinDyazarsayisi[i];
                    }
                    else if (YayinDdoktora[i] == 1 && YayinDbolumSayisi[i] > 0 && YayinDyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (4 * YayinDbolumSayisi[i]) / (decimal)YayinDyazarsayisi[i];
                    }
                }
            }
            if (YayinEdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinEdoktora.Count(); i++)
                {
                    if (YayinEdoktora[i] == 0 && YayinEmakalesayisi[i] > 0 && YayinEyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (8 * YayinEmakalesayisi[i]) / (decimal)YayinEyazarsayisi[i];
                    }
                    else if (YayinEdoktora[i] == 1 && YayinEmakalesayisi[i] > 0 && YayinEyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (8 * YayinEmakalesayisi[i]) / (decimal)YayinEyazarsayisi[i];
                    }
                }
            }

            if (YayinFdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinFdoktora.Count(); i++)
                {
                    if (YayinFdoktora[i] == 0 && YayinFmakalesayisi[i] > 0 && YayinFyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (6 * YayinFmakalesayisi[i]) / (decimal)YayinFyazarsayisi[i];
                    }
                    else if (YayinFdoktora[i] == 1 && YayinFmakalesayisi[i] > 0 && YayinFyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (6 * YayinFmakalesayisi[i]) / (decimal)YayinFyazarsayisi[i];
                    }
                }
            }
            if (YayinGdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinGdoktora.Count(); i++)
                {
                    if (YayinGdoktora[i] == 0 && YayinGmakalesayisi[i] > 0 && YayinGyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (4 * YayinGmakalesayisi[i]) / (decimal)YayinGyazarsayisi[i];
                    }
                    else if (YayinGdoktora[i] == 1 && YayinGmakalesayisi[i] > 0 && YayinGyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (4 * YayinGmakalesayisi[i]) / (decimal)YayinGyazarsayisi[i];
                    }
                }
            }







            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 10) model.NetPuan = 10;


            model.ErrorMessage = "3. Lisansüstü Tezlerden Üretilmiş Yayın maddesi kapsamında en az 1 yayın zorunludur";
            return model;
        }


        #endregion



        #region Kitap
        public int[] KitapAdoktora { get; set; } = default!;
        public int[] KitapAkitap { get; set; } = default!;
        public int[] KitapAyazarsayisi { get; set; } = default!;
        public string[] KitapAhatirlatici { get; set; } = default!;

        public int[] KitapBdoktora { get; set; } = default!;
        public int[] KitapBbolumSayisi { get; set; } = default!;
        public int[] KitapByazarsayisi { get; set; } = default!;
        public string[] KitapBhatirlatici { get; set; } = default!;

        public int[] KitapCdoktora { get; set; } = default!;
        public int[] KitapCkitap { get; set; } = default!;
        public int[] KitapCyazarsayisi { get; set; } = default!;
        public string[] KitapChatirlatici { get; set; } = default!;

        public int[] KitapDdoktora { get; set; } = default!;
        public int[] KitapDbolumSayisi { get; set; } = default!;
        public int[] KitapDyazarsayisi { get; set; } = default!;
        public string[] KitapDhatirlatici { get; set; } = default!;

        private Kitap KitapHesapla()
        {
            Kitap model = new();
            if (KitapAdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapAdoktora.Count(); i++)
                {
                    if (KitapAdoktora[i] == 0 && KitapAkitap[i] > 0 && KitapAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (25 * KitapAkitap[i]) / (decimal)KitapAyazarsayisi[i];
                    }
                    else if (KitapAdoktora[i] == 1 && KitapAkitap[i] > 0 && KitapAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (25 * KitapAkitap[i]) / (decimal)KitapAyazarsayisi[i];
                    }
                }
            }
            if (KitapBdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapBdoktora.Count(); i++)
                {
                    if (KitapBdoktora[i] == 0 && KitapBbolumSayisi[i] > 0 && KitapByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (10 * KitapBbolumSayisi[i]) / (decimal)KitapByazarsayisi[i];
                    }
                    else if (KitapBdoktora[i] == 1 && KitapBbolumSayisi[i] > 0 && KitapByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (10 * KitapBbolumSayisi[i]) / (decimal)KitapByazarsayisi[i];
                    }
                }

            }
            if (KitapCdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapCdoktora.Count(); i++)
                {
                    if (KitapCdoktora[i] == 0 && KitapCkitap[i] > 0 && KitapCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (25 * KitapCkitap[i]) / (decimal)KitapCyazarsayisi[i];
                    }
                    else if (KitapCdoktora[i] == 1 && KitapCkitap[i] > 0 && KitapCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (25 * KitapCkitap[i]) / (decimal)KitapCyazarsayisi[i];
                    }
                }

            }


            if (KitapDdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapDdoktora.Count(); i++)
                {
                    if (KitapDdoktora[i] == 0 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (10 * KitapDbolumSayisi[i]) / (decimal)KitapDyazarsayisi[i];
                    }
                    else if (KitapDdoktora[i] == 1 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (10 * KitapDbolumSayisi[i]) / (decimal)KitapDyazarsayisi[i];
                    }
                }
            }

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;

            return model;
        }



        #endregion



        #region Atiflar
        public int[] AtiflarAdoktora { get; set; } = default!;
        public int[] AtiflarAatif { get; set; } = default!;
        public string[] AtiflarAhatirlatici { get; set; } = default!;

        public int[] AtiflarBdoktora { get; set; } = default!;
        public int[] AtiflarBatif { get; set; } = default!;
        public string[] AtiflarBhatirlatici { get; set; } = default!;

        public int[] AtiflarCdoktora { get; set; } = default!;
        public int[] AtiflarCatif { get; set; } = default!;
        public string[] AtiflarChatirlatici { get; set; } = default!;

        private Atiflar AtifHesapla()
        {
            Atiflar model = new();
            if (AtiflarAdoktora.Count() > 1)
            {
                for (int i = 1; i < AtiflarAdoktora.Count(); i++)
                {
                    if (AtiflarAdoktora[i] == 0 && AtiflarAatif[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 3 * AtiflarAatif[i];
                    }
                    else if (AtiflarAdoktora[i] == 1 && AtiflarAatif[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 3 * AtiflarAatif[i];
                    }
                }
            }
            if (AtiflarBdoktora.Count() > 1)
            {
                for (int i = 1; i < AtiflarBdoktora.Count(); i++)
                {
                    if (AtiflarBdoktora[i] == 0 && AtiflarBatif[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 2 * AtiflarBatif[i];
                    }
                    else if (AtiflarBdoktora[i] == 1 && AtiflarBatif[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 2 * AtiflarBatif[i];
                    }
                }
            }
            if (AtiflarCdoktora.Count() > 1)
            {
                for (int i = 1; i < AtiflarCdoktora.Count(); i++)
                {
                    if (AtiflarCdoktora[i] == 0 && AtiflarCatif[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 1 * AtiflarCatif[i];
                    }
                    else if (AtiflarCdoktora[i] == 1 && AtiflarCatif[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 1 * AtiflarCatif[i];
                    }
                }
            }


            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 20) model.NetPuan = 20;
            if (model.NetPuan < 1) model.Error = true;
            model.ErrorMessage = "5. Atıflar maddesi kapsamında en az 1 atıf alınması zorunludur";
            return model;
        }


        #endregion




        #region Danismanlik
        // altıncı kısım verileri
        public int[] DanismanlikAdoktora { get; set; } = default!;
        public int[] DanismanlikAseviye { get; set; } = default!;
        public int[] DanismanlikAsayi { get; set; } = default!;
        public string[] DanismanlikAhatirlatici { get; set; } = default!;


        public int[] DanismanlikBdoktora { get; set; } = default!;
        public int[] DanismanlikBseviye { get; set; } = default!;
        public int[] DanismanlikBsayi { get; set; } = default!;
        public string[] DanismanlikBhatirlatici { get; set; } = default!;


        private Danismanlik DanismanlikHesapla()
        {
            Danismanlik model = new();
            model.HamDoktoraOncesiPuan = 0;

            if (DanismanlikAdoktora.Count() > 1)
            {
                for (int i = 1; i < DanismanlikAdoktora.Count(); i++)
                {
                    if (DanismanlikAsayi[i] > 0 && DanismanlikAseviye[i] == 0)
                    {
                        model.HamDoktoraSonrasiPuan = 4 * DanismanlikAsayi[i];
                    }
                    else if (DanismanlikAsayi[i] > 0 && DanismanlikAseviye[i] == 1)
                    {
                        model.HamDoktoraSonrasiPuan = 2 * DanismanlikAsayi[i];
                    }
                }
            }
            if (DanismanlikBdoktora.Count() > 1)
            {
                for (int i = 1; i < DanismanlikBdoktora.Count(); i++)
                {
                    if (DanismanlikBsayi[i] > 0 && DanismanlikBseviye[i] == 0)
                    {
                        model.HamDoktoraSonrasiPuan = 2 * DanismanlikBsayi[i];
                    }
                    else if (DanismanlikBsayi[i] > 0 && DanismanlikBseviye[i] == 1)
                    {
                        model.HamDoktoraSonrasiPuan = 1 * DanismanlikBsayi[i];
                    }
                }
            }

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 10) model.NetPuan = 10;



            return model;
        }


        #endregion



        #region Arastirma
        public int[] ArastirmaAdoktora { get; set; } = default!;
        public int[] ArastirmaAproje { get; set; } = default!;
        public string[] ArastirmaAhatirlatici { get; set; } = default!;

        public int[] ArastirmaBdoktora { get; set; } = default!;
        public int[] ArastirmaBproje { get; set; } = default!;
        public string[] ArastirmaBhatirlatici { get; set; } = default!;

        public int[] ArastirmaCdoktora { get; set; } = default!;
        public int[] ArastirmaCproje { get; set; } = default!;
        public string[] ArastirmaChatirlatici { get; set; } = default!;

        public int[] ArastirmaDdoktora { get; set; } = default!;
        public int[] ArastirmaDproje { get; set; } = default!;
        public string[] ArastirmaDhatirlatici { get; set; } = default!;


        private Arastirma ArastirmaHesapla()
        {
            Arastirma model = new();
            if (ArastirmaAdoktora.Count() > 1)
            {
                for (int i = 1; i < ArastirmaAdoktora.Count(); i++)
                {
                    if (ArastirmaAdoktora[i] == 0 && ArastirmaAproje[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 15 * ArastirmaAproje[i];
                    }
                    else if (ArastirmaAdoktora[i] == 1 && ArastirmaAproje[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 15 * ArastirmaAproje[i];
                    }
                }
            }
            if (ArastirmaBdoktora.Count() > 1)
            {
                for (int i = 1; i < ArastirmaBdoktora.Count(); i++)
                {
                    if (ArastirmaBdoktora[i] == 0 && ArastirmaBproje[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 10 * ArastirmaBproje[i];
                    }
                    else if (ArastirmaBdoktora[i] == 1 && ArastirmaBproje[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 10 * ArastirmaBproje[i];
                    }
                }
            }
            if (ArastirmaCdoktora.Count() > 1)
            {
                for (int i = 1; i < ArastirmaCdoktora.Count(); i++)
                {
                    if (ArastirmaCdoktora[i] == 0 && ArastirmaCproje[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 6 * ArastirmaCproje[i];
                    }
                    else if (ArastirmaCdoktora[i] == 1 && ArastirmaCproje[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 6 * ArastirmaCproje[i];
                    }
                }
            }
            if (ArastirmaDdoktora.Count() > 1)
            {
                for (int i = 1; i < ArastirmaDdoktora.Count(); i++)
                {
                    if (ArastirmaDdoktora[i] == 0 && ArastirmaDproje[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 4 * ArastirmaDproje[i];
                    }
                    else if (ArastirmaDdoktora[i] == 1 && ArastirmaDproje[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 4 * ArastirmaDproje[i];
                    }
                }
            }

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 20) model.NetPuan = 20;

            return model;
        }


        #endregion



        #region Toplanti
        public int[] ToplantiAdoktora { get; set; } = default!;
        public int[] ToplantiAsayi { get; set; } = default!;
        public int[] ToplantiAyazarsayisi { get; set; } = default!;
        public string[] ToplantiAhatirlatici { get; set; } = default!;


        public int[] ToplantiBdoktora { get; set; } = default!;
        public int[] ToplantiBsayi { get; set; } = default!;
        public int[] ToplantiByazarsayisi { get; set; } = default!;
        public string[] ToplantiBhatirlatici { get; set; } = default!;


        private Toplanti ToplantiHesapla()
        {
            Toplanti model = new();
            if (ToplantiAdoktora.Count() > 1)
            {
                for (int i = 1; i < ToplantiAdoktora.Count(); i++)
                {
                    if (ToplantiAdoktora[i] == 0 && ToplantiAsayi[i] > 0 && ToplantiAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (3 * ToplantiAsayi[i]) / (decimal)ToplantiAyazarsayisi[i];
                    }
                    else if (ToplantiAdoktora[i] == 1 && ToplantiAsayi[i] > 0 && ToplantiAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (3 * ToplantiAsayi[i]) / (decimal)ToplantiAyazarsayisi[i];
                    }
                }

            }
            if (ToplantiBdoktora.Count() > 1)
            {
                for (int i = 1; i < ToplantiBdoktora.Count(); i++)
                {
                    if (ToplantiBdoktora[i] == 0 && ToplantiBsayi[i] > 0 && ToplantiByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (2 * ToplantiBsayi[i]) / (decimal)ToplantiByazarsayisi[i];
                    }
                    else if (ToplantiBdoktora[i] == 1 && ToplantiBsayi[i] > 0 && ToplantiByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (2 * ToplantiBsayi[i]) / (decimal)ToplantiByazarsayisi[i];
                    }
                }

            }


            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 10) model.NetPuan = 10;
            if (model.NetPuan < 5) model.Error = true;


            model.ErrorMessage = "8. Bilimsel Toplantı Faaliyeti maddesi kapsamında en az 5 puan almak zorunludur";
            return model;
        }

        #endregion




        #region Egitim
        public int[] EgitimAdoktora { get; set; } = default!;
        public int[] EgitimAders { get; set; } = default!;
        public string[] EgitimAhatirlatici { get; set; } = default!;

        public int[] EgitimBdoktora { get; set; } = default!;
        public int[] EgitimBders { get; set; } = default!;
        public string[] EgitimBhatirlatici { get; set; } = default!;

        public bool Gorev2yil { get; set; } = false;
        // başka bir eğitimle çakıştığı için linki burda verdim
        private DocentlikPuanHesaplama.Models.Bolumler.Egitim EgitimHesapla()
        {
            DocentlikPuanHesaplama.Models.Bolumler.Egitim model = new();
            if (EgitimAdoktora.Count() > 1)
            {
                for (int i = 1; i < EgitimAdoktora.Count(); i++)
                {
                    if (EgitimAdoktora[i] == 0 && EgitimAders[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 3 * EgitimAders[i];
                    }
                    else if (EgitimAdoktora[i] == 1 && EgitimAders[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 3 * EgitimAders[i];
                    }
                }
            }
            if (Gorev2yil == false)
            {

                if (EgitimBdoktora.Count() > 1)
                {
                    for (int i = 1; i < EgitimBdoktora.Count(); i++)
                    {
                        if (EgitimBdoktora[i] == 0 && EgitimBders[i] > 0)
                        {
                            model.HamDoktoraOncesiPuan += 2 * EgitimBders[i];
                        }
                        else if (EgitimBdoktora[i] == 1 && EgitimBders[i] > 0)
                        {
                            model.HamDoktoraSonrasiPuan += 2 * EgitimBders[i];
                        }
                    }
                }
            }
            else
            {
                model.HamDoktoraSonrasiPuan += 2;
            }

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 4) model.NetPuan = 4;
            if (model.NetPuan < 2) model.Error = true;
            model.ErrorMessage = "9. Eğitim-Öğretim Faaliyeti kapsamında en az 2 puan almak zorunludur.";
            return model;
        }



        #endregion

       
        
        




        public Messages Hesapla()
        {
            Messages message = new();
            message.Error = false;
            message.NetToplamDoktoraSonrasi = 0;
            message.ToplamDoktoraOncesi = 0;
            message.ToplamDoktoraSonrasi = 0;
            UluslarArasi UluslarArasi = UluslarArasiHesapla();
            if (UluslarArasi != null)
            {
                message.ToplamNetPuan += UluslarArasi.NetPuan;
                message.ToplamDoktoraOncesi += UluslarArasi.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += UluslarArasi.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = UluslarArasi.BolumAdi,
                    HamDoktoraOncesi = UluslarArasi.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = UluslarArasi.HamDoktoraSonrasiPuan,
                    NetPuan = UluslarArasi.NetPuan,
                    Error = UluslarArasi.Error,
                    ErrorMessage = UluslarArasi.ErrorMessage
                };
                if (UluslarArasi.Error == true) message.Error = true;

                message.NetToplamDoktoraSonrasi += UluslarArasi.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }


            Ulusal Ulusal = UlusalHesapla();
            if (Ulusal != null)
            {
                message.ToplamNetPuan += Ulusal.NetPuan;
                message.ToplamDoktoraOncesi += Ulusal.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Ulusal.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Ulusal.BolumAdi,
                    HamDoktoraOncesi = Ulusal.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Ulusal.HamDoktoraSonrasiPuan,
                    NetPuan = Ulusal.NetPuan,
                    Error = Ulusal.Error,
                    ErrorMessage = Ulusal.ErrorMessage
                };
                if (Ulusal.Error == true) message.Error = true;
                message.NetToplamDoktoraSonrasi += Ulusal.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }



            Yayin Yayin = YayinHesapla();
            if (Yayin != null)
            {
                message.ToplamNetPuan += Yayin.NetPuan;
                message.ToplamDoktoraOncesi += Yayin.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Yayin.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Yayin.BolumAdi,
                    HamDoktoraOncesi = Yayin.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Yayin.HamDoktoraSonrasiPuan,
                    NetPuan = Yayin.NetPuan,
                    Error = Yayin.Error,
                    ErrorMessage = Yayin.ErrorMessage
                };
                if (Yayin.Error == true) message.Error = true;
                if (Yayin.HamDoktoraSonrasiPuan > 10)
                {
                    message.NetToplamDoktoraSonrasi += 10;
                }
                else
                {
                    message.NetToplamDoktoraSonrasi += Yayin.HamDoktoraSonrasiPuan;
                }
                message.Bolumler.Add(madde);
            }


            Kitap Kitap = KitapHesapla();
            if (Kitap != null)
            {
                message.ToplamNetPuan += Kitap.NetPuan;
                message.ToplamDoktoraOncesi += Kitap.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Kitap.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Kitap.BolumAdi,
                    HamDoktoraOncesi = Kitap.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Kitap.HamDoktoraSonrasiPuan,
                    NetPuan = Kitap.NetPuan,
                    Error = Kitap.Error,
                    ErrorMessage = Kitap.ErrorMessage
                };
                if (Kitap.Error == true) message.Error = true;

                message.NetToplamDoktoraSonrasi += Kitap.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }


            Atiflar Atiflar = AtifHesapla();
            if (Atiflar != null)
            {
                message.ToplamNetPuan += Atiflar.NetPuan;
                message.ToplamDoktoraOncesi += Atiflar.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Atiflar.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Atiflar.BolumAdi,
                    HamDoktoraOncesi = Atiflar.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Atiflar.HamDoktoraSonrasiPuan,
                    NetPuan = Atiflar.NetPuan,
                    Error = Atiflar.Error,
                    ErrorMessage = Atiflar.ErrorMessage
                };
                if (Atiflar.Error == true) message.Error = true;

                if (Atiflar.HamDoktoraSonrasiPuan > 20)
                {
                    message.NetToplamDoktoraSonrasi += 20;
                }
                else message.NetToplamDoktoraSonrasi += Atiflar.HamDoktoraSonrasiPuan;

                message.Bolumler.Add(madde);
            }


            Danismanlik Danismanlik = DanismanlikHesapla();
            if (Danismanlik != null)
            {
                message.ToplamNetPuan += Danismanlik.NetPuan;
                message.ToplamDoktoraOncesi += Danismanlik.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Danismanlik.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Danismanlik.BolumAdi,
                    HamDoktoraOncesi = Danismanlik.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Danismanlik.HamDoktoraSonrasiPuan,
                    NetPuan = Danismanlik.NetPuan,
                    Error = Danismanlik.Error,
                    ErrorMessage = Danismanlik.ErrorMessage
                };
                if (Danismanlik.Error == true) message.Error = true;

                if (Danismanlik.HamDoktoraSonrasiPuan > 20)
                {
                    message.NetToplamDoktoraSonrasi += 20;
                }
                else message.NetToplamDoktoraSonrasi += Danismanlik.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }


            Arastirma Arastirma = ArastirmaHesapla();
            if (Arastirma != null)
            {
                message.ToplamNetPuan += Arastirma.NetPuan;
                message.ToplamDoktoraOncesi += Arastirma.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Arastirma.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Arastirma.BolumAdi,
                    HamDoktoraOncesi = Arastirma.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Arastirma.HamDoktoraSonrasiPuan,
                    NetPuan = Arastirma.NetPuan,
                    Error = Arastirma.Error,
                    ErrorMessage = Arastirma.ErrorMessage
                };
                if (Arastirma.Error == true) message.Error = true;

                if (Arastirma.HamDoktoraSonrasiPuan > 20)
                {
                    message.NetToplamDoktoraSonrasi += 20;
                }
                else message.NetToplamDoktoraSonrasi += Arastirma.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }

            Toplanti Toplanti = ToplantiHesapla();
            if (Toplanti != null)
            {
                message.ToplamNetPuan += Toplanti.NetPuan;
                message.ToplamDoktoraOncesi += Toplanti.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Toplanti.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Toplanti.BolumAdi,
                    HamDoktoraOncesi = Toplanti.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Toplanti.HamDoktoraSonrasiPuan,
                    NetPuan = Toplanti.NetPuan,
                    Error = Toplanti.Error,
                    ErrorMessage = Toplanti.ErrorMessage
                };
                if (Toplanti.Error == true) message.Error = true;
                if (Toplanti.HamDoktoraSonrasiPuan > 10)
                    message.NetToplamDoktoraSonrasi += 10;
                else message.NetToplamDoktoraSonrasi += Toplanti.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }

            DocentlikPuanHesaplama.Models.Bolumler.Egitim Egitim = EgitimHesapla();
            if (Egitim != null)
            {
                message.ToplamNetPuan += Egitim.NetPuan;
                message.ToplamDoktoraOncesi += Egitim.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Egitim.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Egitim.BolumAdi,
                    HamDoktoraOncesi = Egitim.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Egitim.HamDoktoraSonrasiPuan,
                    NetPuan = Egitim.NetPuan,
                    Error = Egitim.Error,
                    ErrorMessage = Egitim.ErrorMessage
                };
                if (Egitim.Error == true) message.Error = true;

                if (Egitim.HamDoktoraSonrasiPuan > 4)
                    message.NetToplamDoktoraSonrasi += 4;
                else message.NetToplamDoktoraSonrasi += Egitim.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);
            }



            if (message.NetToplamDoktoraSonrasi < 90 || message.NetToplamDoktoraSonrasi < 100)
            {
                message.AsgariMessage = " - Doktora sonrası en az 90 Net puan elde edilmiş olmalıdır Toplam Asgari 100 Net puan olmalıdır !";
                message.Error = true;
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
