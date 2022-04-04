using DocentlikPuanHesaplama.IdentityModel;
using DocentlikPuanHesaplama.Models.Bolumler;

namespace DocentlikPuanHesaplama.Models.Egitim
{
    public class EgitimDocentModel
    {

        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region UluslarArasi
        public int[] UluslarArasiAdoktora { get; set; } = default!;
        public int[] UluslarArasiAmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiAyazarsayisi { get; set; } = default!;
        public string[]? UluslarArasiAhatirlatici { get; set; } = default!;

        public int[] UluslarArasiBdoktora { get; set; } = default!;
        public int[] UluslarArasiBmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiByazarsayisi { get; set; } = default!;
        public string[]? UluslarArasiBhatirlatici { get; set; } = default!;

        public int[] UluslarArasiCdoktora { get; set; } = default!;
        public int[] UluslarArasiCmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiCyazarsayisi { get; set; } = default!;
        public string[]? UluslarArasiChatirlatici { get; set; } = default!;


        private UluslarArasi UluslarArasiHesapla()
        {
            UluslarArasi model = new();
            if (UluslarArasiAdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiAdoktora.Count(); i++)
                {
                    // 0. indexteki numune olduğundan dolayı almadım diğer 2 parametre 0 girilmesine tedbiren
                    if (UluslarArasiAdoktora[i] == 0 && UluslarArasiAmakalesayisi[i] > 0 && UluslarArasiAyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (20 * UluslarArasiAmakalesayisi[i]) / UluslarArasiAyazarsayisi[i];
                    }
                    else if (UluslarArasiAdoktora[i] == 1 && UluslarArasiAmakalesayisi[i] > 0 && UluslarArasiAyazarsayisi[i] > 0)
                    {// else yazarsam 0  girilen değerleride alır
                        model.HamDoktoraSonrasiPuan += (20 * UluslarArasiAmakalesayisi[i]) / UluslarArasiAyazarsayisi[i];
                    }
                }

            }
            if (UluslarArasiBdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiBdoktora.Count(); i++)
                {
                    // 0. indexteki numune olduğundan dolayı almadım diğer 2 parametre 0 girilmesine tedbiren
                    if (UluslarArasiBdoktora[i] == 0 && UluslarArasiBmakalesayisi[i] > 0 && UluslarArasiByazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (15 * UluslarArasiBmakalesayisi[i]) / UluslarArasiByazarsayisi[i];
                    }
                    else if (UluslarArasiBdoktora[i] == 1 && UluslarArasiBmakalesayisi[i] > 0 && UluslarArasiByazarsayisi[i] > 0)
                    {// else yazarsam 0  girilen değerleride alır
                        model.HamDoktoraSonrasiPuan += (15 * UluslarArasiBmakalesayisi[i]) / UluslarArasiByazarsayisi[i];
                    }
                }

            }
            // c seçeniğe girmeden kontrol işlemi yapıyorumki ekstra değişken tanımlama işlemi yapmiyalım 
            if (model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan < 20) model.Error = true;
            if (UluslarArasiCdoktora.Count() > 1)
            {
                for (int i = 1; i < UluslarArasiCdoktora.Count(); i++)
                {
                    // 0. indexteki numune olduğundan dolayı almadım diğer 2 parametre 0 girilmesine tedbiren
                    if (UluslarArasiCdoktora[i] == 0 && UluslarArasiCmakalesayisi[i] > 0 && UluslarArasiCyazarsayisi[i] > 0) // doktora öncesi
                    {
                        model.HamDoktoraOncesiPuan += (5 * UluslarArasiCmakalesayisi[i]) / UluslarArasiCyazarsayisi[i];
                    }
                    else if (UluslarArasiCdoktora[i] == 1 && UluslarArasiCmakalesayisi[i] > 0 && UluslarArasiCyazarsayisi[i] > 0)
                    {// else yazarsam 0  girilen değerleride alır
                        model.HamDoktoraSonrasiPuan += (5 * UluslarArasiCmakalesayisi[i]) / UluslarArasiCyazarsayisi[i];
                    }
                }

            }
            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            model.ErrorMessage = "1. Uluslararası Makale  maddesinin a veya b bentleri kapsamında en az 20 puan almak zorunludur";
            return model;
        }

        #endregion


        #region Ulusal
        public int[] UlusalAdoktora { get; set; } = default!;
        public int[] UlusalAmakalesayisi { get; set; } = default!;
        public int[] UlusalAyazarsayisi { get; set; } = default!;
        public string[]? UlusalAhatirlatici { get; set; } = default!;


        public int[] UlusalBdoktora { get; set; } = default!;
        public int[] UlusalBmakalesayisi { get; set; } = default!;
        public int[] UlusalByazarsayisi { get; set; } = default!;
        public string[]? UlusalBhatirlatici { get; set; } = default!;
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
                        model.HamDoktoraOncesiPuan += (8 * UlusalAmakalesayisi[i]) / UlusalAyazarsayisi[i];
                    }
                    else if (UlusalAdoktora[i] == 1 && UlusalAmakalesayisi[i] > 0 && UlusalAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (8 * UlusalAmakalesayisi[i]) / UlusalAyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (4 * UlusalBmakalesayisi[i]) / UlusalByazarsayisi[i];
                    }
                    else if (UlusalBdoktora[i] == 1 && UlusalBmakalesayisi[i] > 0 && UlusalByazarsayisi[i] > 0)
                    {
                        sartB += UlusalBmakalesayisi[i];
                        model.HamDoktoraSonrasiPuan += (4 * UlusalBmakalesayisi[i]) / UlusalByazarsayisi[i];
                    }
                }

            }

            if (sart < 2 ||(sart==2&& sartB==0 )) model.Error = true;

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;

            
            model.ErrorMessage = "2. Ulusal Makale İkisi bu maddenin a bendi kapsamında olmak üzere en az üç yayın yapmak";
            return model;
        }

        #endregion


        #region Yayin
        public int[] YayinAdoktora { get; set; } = default!;
        public int[] YayinAkitap { get; set; } = default!;
        public int[] YayinAyazarsayisi { get; set; } = default!;
        public string[]? YayinAhatirlatici { get; set; } = default!;

        public int[] YayinBdoktora { get; set; } = default!;
        public int[] YayinBbolumSayisi { get; set; } = default!;
        public int[] YayinByazarsayisi { get; set; } = default!;
        public string[]? YayinBhatirlatici { get; set; } = default!;

        public int[] YayinCdoktora { get; set; } = default!;
        public int[] YayinCkitap { get; set; } = default!;
        public int[] YayinCyazarsayisi { get; set; } = default!;
        public string[]? YayinChatirlatici { get; set; } = default!;

        public int[] YayinDdoktora { get; set; } = default!;
        public int[] YayinDbolumSayisi { get; set; } = default!;
        public int[] YayinDyazarsayisi { get; set; } = default!;
        public string[]? YayinDhatirlatici { get; set; } = default!;

        public int[] YayinEdoktora { get; set; } = default!;
        public int[] YayinEmakalesayisi { get; set; } = default!;
        public int[] YayinEyazarsayisi { get; set; } = default!;
        public string[]? YayinEhatirlatici { get; set; } = default!;

        public int[] YayinFdoktora { get; set; } = default!;
        public int[] YayinFmakalesayisi { get; set; } = default!;
        public int[] YayinFyazarsayisi { get; set; } = default!;
        public string[]? YayinFhatirlatici { get; set; } = default!;

        public int[] YayinGdoktora { get; set; } = default!;
        public int[] YayinGmakalesayisi { get; set; } = default!;
        public int[] YayinGyazarsayisi { get; set; } = default!;
        public string[]? YayinGhatirlatici { get; set; } = default!;
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
                        model.HamDoktoraOncesiPuan += (10 * YayinAkitap[i]) / YayinAyazarsayisi[i];
                    }
                    else if (YayinAdoktora[i] == 1 && YayinAkitap[i] > 0 && YayinAyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (10 * YayinAkitap[i]) / YayinAyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (8 * YayinBbolumSayisi[i]) / YayinByazarsayisi[i];
                    }
                    else if (YayinBdoktora[i] == 1 && YayinBbolumSayisi[i] > 0 && YayinByazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (8 * YayinBbolumSayisi[i]) / YayinByazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (5 * YayinCkitap[i]) / YayinCyazarsayisi[i];
                    }
                    else if (YayinCdoktora[i] == 1 && YayinCkitap[i] > 0 && YayinCyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (5 * YayinCkitap[i]) / YayinCyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (4 * YayinDbolumSayisi[i]) / YayinDyazarsayisi[i];
                    }
                    else if (YayinDdoktora[i] == 1 && YayinDbolumSayisi[i] > 0 && YayinDyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (4 * YayinDbolumSayisi[i]) / YayinDyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (8 * YayinEmakalesayisi[i]) / YayinEyazarsayisi[i];
                    }
                    else if (YayinEdoktora[i] == 1 && YayinEmakalesayisi[i] > 0 && YayinEyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (8 * YayinEmakalesayisi[i]) / YayinEyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (6 * YayinFmakalesayisi[i]) / YayinFyazarsayisi[i];
                    }
                    else if (YayinFdoktora[i] == 1 && YayinFmakalesayisi[i] > 0 && YayinFyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (6 * YayinFmakalesayisi[i]) / YayinFyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (4 * YayinGmakalesayisi[i]) / YayinGyazarsayisi[i];
                    }
                    else if (YayinGdoktora[i] == 1 && YayinGmakalesayisi[i] > 0 && YayinGyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (4 * YayinGmakalesayisi[i]) / YayinGyazarsayisi[i];
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
        public string[]? KitapAhatirlatici { get; set; } = default!;

        public int[] KitapBdoktora { get; set; } = default!;
        public int[] KitapBbolumSayisi { get; set; } = default!;
        public int[] KitapByazarsayisi { get; set; } = default!;
        public string[]? KitapBhatirlatici { get; set; } = default!;

        public int[] KitapCdoktora { get; set; } = default!;
        public int[] KitapCkitap { get; set; } = default!;
        public int[] KitapCyazarsayisi { get; set; } = default!;
        public string[]? KitapChatirlatici { get; set; } = default!;

        public int[] KitapDdoktora { get; set; } = default!;
        public int[] KitapDbolumSayisi { get; set; } = default!;
        public int[] KitapDyazarsayisi { get; set; } = default!;
        public string[]? KitapDhatirlatici { get; set; } = default!;

        private Kitap KitapHesapla()
        {
            Kitap model = new();
            if (KitapAdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapAdoktora.Count(); i++)
                {
                    if (KitapAdoktora[i] == 0 && KitapAkitap[i] > 0 && KitapAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (20 * KitapAkitap[i]) / KitapAyazarsayisi[i];
                    }
                    else if (KitapAdoktora[i] == 1 && KitapAkitap[i] > 0 && KitapAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * KitapAkitap[i]) / KitapAyazarsayisi[i];
                    }
                }
            }
            if (KitapBdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapBdoktora.Count(); i++)
                {
                    if (KitapBdoktora[i] == 0 && KitapBbolumSayisi[i] > 0 && KitapByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (10 * KitapBbolumSayisi[i]) / KitapByazarsayisi[i];
                    }
                    else if (KitapBdoktora[i] == 1 && KitapBbolumSayisi[i] > 0 && KitapByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (10 * KitapBbolumSayisi[i]) / KitapByazarsayisi[i];
                    }
                }

            }
            if (KitapCdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapCdoktora.Count(); i++)
                {
                    if (KitapCdoktora[i] == 0 && KitapCkitap[i] > 0 && KitapCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (15 * KitapCkitap[i]) / KitapCyazarsayisi[i];
                    }
                    else if (KitapCdoktora[i] == 1 && KitapCkitap[i] > 0 && KitapCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (15 * KitapCkitap[i]) / KitapCyazarsayisi[i];
                    }
                }

            }

            if (KitapDdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapDdoktora.Count(); i++)
                {
                    if (KitapDdoktora[i] == 0 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (8 * KitapDbolumSayisi[i]) / KitapDyazarsayisi[i];
                    }
                    else if (KitapDdoktora[i] == 1 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (8 * KitapDbolumSayisi[i]) / KitapDyazarsayisi[i];
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
        public string[]? AtiflarAhatirlatici { get; set; } = default!;

        public int[] AtiflarBdoktora { get; set; } = default!;
        public int[] AtiflarBatif { get; set; } = default!;
        public string[]? AtiflarBhatirlatici { get; set; } = default!;

        public int[] AtiflarCdoktora { get; set; } = default!;
        public int[] AtiflarCatif { get; set; } = default!;
        public string[]? AtiflarChatirlatici { get; set; } = default!;

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
                        model.HamDoktoraOncesiPuan += 3 * AtiflarBatif[i];
                    }
                    else if (AtiflarBdoktora[i] == 1 && AtiflarBatif[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 3 * AtiflarBatif[i];
                    }
                }
            }
            if (AtiflarCdoktora.Count() > 1)
            {
                for (int i = 1; i < AtiflarCdoktora.Count(); i++)
                {
                    if (AtiflarCdoktora[i] == 0 && AtiflarCatif[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += 3 * AtiflarCatif[i];
                    }
                    else if (AtiflarCdoktora[i] == 1 && AtiflarCatif[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += 3 * AtiflarCatif[i];
                    }
                }
            }


            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 20) model.NetPuan = 20;
            if (model.NetPuan < 4) model.Error = true;
            model.ErrorMessage = "5. Atıflar maddesi kapsamında en az 4 puan alınması zorunludur";
            return model;
        }


        #endregion




        #region Danismanlik
        // altıncı kısım verileri
        public int[] DanismanlikAdoktora { get; set; } = default!;
        public int[] DanismanlikAseviye { get; set; } = default!;
        public int[] DanismanlikAsayi { get; set; } = default!;
        public string[]? DanismanlikAhatirlatici { get; set; } = default!;


        public int[] DanismanlikBdoktora { get; set; } = default!;
        public int[] DanismanlikBseviye { get; set; } = default!;
        public int[] DanismanlikBsayi { get; set; } = default!;
        public string[]? DanismanlikBhatirlatici { get; set; } = default!;

        #endregion



        #region Arastirma
        public int[] ArastirmaAdoktora { get; set; } = default!;
        public int[] ArastirmaAproje { get; set; } = default!;
        public string[]? ArastirmaAhatirlatici { get; set; } = default!;

        public int[] ArastirmaBdoktora { get; set; } = default!;
        public int[] ArastirmaBproje { get; set; } = default!;
        public string[]? ArastirmaBhatirlatici { get; set; } = default!;

        public int[] ArastirmaCdoktora { get; set; } = default!;
        public int[] ArastirmaCproje { get; set; } = default!;
        public string[]? ArastirmaChatirlatici { get; set; } = default!;

        public int[] ArastirmaDdoktora { get; set; } = default!;
        public int[] ArastirmaDproje { get; set; } = default!;
        public string[]? ArastirmaDhatirlatici { get; set; } = default!;
        #endregion



        #region Toplanti
        public int[] ToplantiAdoktora { get; set; } = default!;
        public int[] ToplantiAsayi { get; set; } = default!;
        public int[] ToplantiAyazarsayisi { get; set; } = default!;
        public string[]? ToplantiAhatirlatici { get; set; } = default!;


        public int[] ToplantiBdoktora { get; set; } = default!;
        public int[] ToplantiBsayi { get; set; } = default!;
        public int[] ToplantiByazarsayisi { get; set; } = default!;
        public string[]? ToplantiBhatirlatici { get; set; } = default!;
        #endregion




        #region Egitim
        public int[] EgitimAdoktora { get; set; } = default!;
        public int[] EgitimAders { get; set; } = default!;
        public string[]? EgitimAhatirlatici { get; set; } = default!;

        public int[] EgitimBdoktora { get; set; } = default!;
        public int[] EgitimBders { get; set; } = default!;
        public string[]? EgitimBhatirlatici { get; set; } = default!;

        public bool Gorev2yil { get; set; } = false;
        #endregion

        //public decimal NetTotalPuan { get; set; } = 0;
        //public decimal HamTotalDoktoraOncesiPuan { get; set; } = 0;
        //public decimal HamTotalDoktoraSonrasiPuan { get; set; } = 0;

        //public string[]? Message { get; set; } = default;
        //public bool Sonuc { get; set; } = false;

        public Messages Hesapla()
        {
            Messages message = new();
            message.Error = false;
            message.ToplamDoktoraOncesi = 0;
            message.ToplamDoktoraSonrasi = 0;
            UluslarArasi UluslarArasi = UluslarArasiHesapla();
            if (UluslarArasi != null)
            {
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
