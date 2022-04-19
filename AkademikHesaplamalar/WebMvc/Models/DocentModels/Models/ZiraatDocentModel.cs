using WebMvc.Models;
using WebMvc.Models.DocentModels.Bolumler;
using Core.Models;

namespace WebMvc.Models.DocentModels.Models
{
    public class ZiraatDocentModel
    {

        public decimal YazarSirasi(int YazarSayisi, int YazarSirasi, bool basYazar)
        {
            if (basYazar == false)
            {
                return 1.0m / (decimal)YazarSayisi;
            }
            else
            {

                if (YazarSayisi == 1 && YazarSirasi == 1) return 1.0m;
                else if (YazarSayisi == 2)
                {
                    if (YazarSirasi == 1) return 0.8m;
                    else return 0.5m;
                }
                else if (YazarSirasi > 1 && YazarSayisi > 1) return 0.5m / ((decimal)YazarSayisi - 1);// baş yazarı çıkarıp kalan kişi sayısına böldüm
                else
                {
                    return 1;
                }
            }

        }
        public int Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Makaleler

        public int[] MakalelerAdoktora { get; set; } = default!;
        public int[] MakalelerAmakalesayisi { get; set; } = default!;
        public int[] MakalelerAyazarsayisi { get; set; } = default!;
        public int[] MakalelerAsirasi { get; set; } = default!;
        public string[] MakalelerAhatirlatici { get; set; } = default!;
        public bool[] MakalelerAbasYazar { get; set; } = default!;

        public int[] MakalelerBdoktora { get; set; } = default!;
        public int[] MakalelerBmakalesayisi { get; set; } = default!;
        public int[] MakalelerByazarsayisi { get; set; } = default!;
        public int[] MakalelerBsirasi { get; set; } = default!;
        public string[] MakalelerBhatirlatici { get; set; } = default!;
        public bool[] MakalelerBbasYazar { get; set; } = default!;


        public int[] MakalelerCdoktora { get; set; } = default!;
        public int[] MakalelerCmakalesayisi { get; set; } = default!;
        public int[] MakalelerCyazarsayisi { get; set; } = default!;
        public int[] MakalelerCsirasi { get; set; } = default!;
        public string[] MakalelerChatirlatici { get; set; } = default!;
        public bool[] MakalelerCbasYazar { get; set; } = default!;





        private Makaleler MakalelerHesapla()
        {
            Makaleler model = new();
            int BaslicaYazar = 0;
            // ekstra değişken oluşturmamak için önce c yi kotnrol edeceğim
            if (MakalelerCdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerCdoktora.Count(); i++)
                {
                    if (MakalelerCdoktora[i] == 0 && MakalelerCmakalesayisi[i] > 0 && MakalelerCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (8 * MakalelerCmakalesayisi[i]) *
                                   (decimal)YazarSirasi(MakalelerCyazarsayisi[i], MakalelerCsirasi[i], MakalelerCbasYazar[i]);
                    }
                    else if (MakalelerCdoktora[i] == 1 && MakalelerCmakalesayisi[i] > 0 && MakalelerCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (8 * MakalelerCmakalesayisi[i]) *
                             (decimal)YazarSirasi(MakalelerCyazarsayisi[i], MakalelerCsirasi[i], MakalelerCbasYazar[i]);
                    }
                }
            }

            if (model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan < 8)
            {
                model.Error = true;
                model.ErrorMessage = "1. Makaleeler maddesinin c bendi kapsamında en az 8 puan almak zorunludur";
            }
            if (MakalelerAdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerAdoktora.Count(); i++)
                {
                    if (MakalelerAbasYazar[i] == true || MakalelerAyazarsayisi[i]==1) BaslicaYazar += 20 * MakalelerAmakalesayisi[i];
                    if (MakalelerAdoktora[i] == 0 && MakalelerAmakalesayisi[i] > 0 && MakalelerAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (20 * MakalelerAmakalesayisi[i]) *
                            (decimal)YazarSirasi(MakalelerAyazarsayisi[i], MakalelerAsirasi[i], MakalelerAbasYazar[i]);
                    }
                    else if (MakalelerAdoktora[i] == 1 && MakalelerAmakalesayisi[i] > 0 && MakalelerAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * MakalelerAmakalesayisi[i]) *
                              (decimal)YazarSirasi(MakalelerAyazarsayisi[i], MakalelerAsirasi[i], MakalelerAbasYazar[i]);
                    }
                }

            }
            if (BaslicaYazar < 40)
            {
                model.Error = true;
                model.ErrorMessage = "1. Makaleeler maddesi kapsamında başlıca yazar olmak kaydıyla, en az 40 puan almak zorunludur ";
            }

            if (MakalelerBdoktora.Count() > 1)
            {
                for (int i = 1; i < MakalelerBdoktora.Count(); i++)
                {
                    if (MakalelerBdoktora[i] == 0 && MakalelerBmakalesayisi[i] > 0 && MakalelerByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (8 * MakalelerBmakalesayisi[i]) *
                              (decimal)YazarSirasi(MakalelerByazarsayisi[i], MakalelerBsirasi[i], MakalelerBbasYazar[i]);
                    }
                    else if (MakalelerBdoktora[i] == 1 && MakalelerBmakalesayisi[i] > 0 && MakalelerByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (8 * MakalelerBmakalesayisi[i]) *
                              (decimal)YazarSirasi(MakalelerByazarsayisi[i], MakalelerBsirasi[i], MakalelerBbasYazar[i]);
                    }
                }

            }


            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            model.BolumAdi = "1. Makaleler";

            return model;
        }






        #endregion



        #region Yayin
        public int[] YayinAdoktora { get; set; } = default!;
        public int[] YayinAmakalesayisi { get; set; } = default!;
        public int[] YayinAyazarsayisi { get; set; } = default!;
        public int[] YayinAsirasi { get; set; } = default!;
        public string[] YayinAhatirlatici { get; set; } = default!;
        public bool[] YayinAbasYazar { get; set; } = default!;


        public int[] YayinBdoktora { get; set; } = default!;
        public int[] YayinBmakalesayisi { get; set; } = default!;
        public int[] YayinBsirasi { get; set; } = default!;
        public string[] YayinBhatirlatici { get; set; } = default!;
        public int[] YayinByazarsayisi { get; set; } = default!;
        public bool[] YayinBbasYazar { get; set; } = default!;





        public int[] YayinCdoktora { get; set; } = default!;
        public int[] YayinCbildiri { get; set; } = default!;
        public int[] YayinCyazarsayisi { get; set; } = default!;
        public string[] YayinChatirlatici { get; set; } = default!;

        public int[] YayinDdoktora { get; set; } = default!;
        public int[] YayinDbildiri { get; set; } = default!;
        public int[] YayinDyazarsayisi { get; set; } = default!;
        public string[] YayinDhatirlatici { get; set; } = default!;


        private Yayin YayinHesapla()
        {
            Yayin model = new();
            if (YayinAdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinAdoktora.Count(); i++)
                {
                    if (YayinAdoktora[i] == 0 && YayinAmakalesayisi[i] > 0 && YayinAyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (10 * YayinAmakalesayisi[i]) *
                            (decimal)YazarSirasi(YayinAyazarsayisi[i], YayinAsirasi[i], YayinAbasYazar[i]);
                    }
                    else if (YayinAdoktora[i] == 1 && YayinAmakalesayisi[i] > 0 && YayinAyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (10 * YayinAmakalesayisi[i]) *
                            (decimal)YazarSirasi(YayinAyazarsayisi[i], YayinAsirasi[i], YayinAbasYazar[i]);
                    }
                }
            }
            if (YayinBdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinBdoktora.Count(); i++)
                {
                    if (YayinBdoktora[i] == 0 && YayinBmakalesayisi[i] > 0 && YayinByazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (5 * YayinBmakalesayisi[i]) *
                            (decimal)YazarSirasi(YayinByazarsayisi[i], YayinBsirasi[i], YayinBbasYazar[i]);
                    }
                    else if (YayinBdoktora[i] == 1 && YayinBmakalesayisi[i] > 0 && YayinByazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (5 * YayinBmakalesayisi[i]) *
                            (decimal)YazarSirasi(YayinByazarsayisi[i], YayinBsirasi[i], YayinBbasYazar[i]);
                    }
                }

            }
            if (YayinCdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinCdoktora.Count(); i++)
                {
                    if (YayinCdoktora[i] == 0 && YayinCbildiri[i] > 0 && YayinCyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (5 * YayinCbildiri[i]) / (decimal)YayinCyazarsayisi[i];
                    }
                    else if (YayinCdoktora[i] == 1 && YayinCbildiri[i] > 0 && YayinCyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (5 * YayinCbildiri[i]) / (decimal)YayinCyazarsayisi[i];
                    }
                }

            }

            if (YayinDdoktora.Count() > 1)
            {
                for (int i = 1; i < YayinDdoktora.Count(); i++)
                {
                    if (YayinDdoktora[i] == 0 && YayinDbildiri[i] > 0 && YayinDyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraOncesiPuan += (3 * YayinDbildiri[i]) / (decimal)YayinDyazarsayisi[i];
                    }
                    else if (YayinDdoktora[i] == 1 && YayinDbildiri[i] > 0 && YayinDyazarsayisi[i] > 0)
                    {
                        model.Error = false;
                        model.HamDoktoraSonrasiPuan += (3 * YayinDbildiri[i]) / (decimal)YayinDyazarsayisi[i];
                    }
                }
            }





            model.BolumAdi = "2. Lisansüstü Tezlerden Üretilmiş Yayın ";

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;
            if (model.NetPuan > 10) model.NetPuan = 10;

            model.ErrorMessage = "2. Lisansüstü Tezlerden Üretilmiş Yayın maddesin  en az bir yayın zorunludur.";
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
                        model.HamDoktoraOncesiPuan += (20 * KitapAkitap[i]) / (decimal)KitapAyazarsayisi[i];
                    }
                    else if (KitapAdoktora[i] == 1 && KitapAkitap[i] > 0 && KitapAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * KitapAkitap[i]) / (decimal)KitapAyazarsayisi[i];
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
                        model.HamDoktoraOncesiPuan += (15 * KitapCkitap[i]) / (decimal)KitapCyazarsayisi[i];
                    }
                    else if (KitapCdoktora[i] == 1 && KitapCkitap[i] > 0 && KitapCyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (15 * KitapCkitap[i]) / (decimal)KitapCyazarsayisi[i];
                    }
                }

            }

            if (KitapDdoktora.Count() > 1)
            {
                for (int i = 1; i < KitapDdoktora.Count(); i++)
                {
                    if (KitapDdoktora[i] == 0 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (8 * KitapDbolumSayisi[i]) / (decimal)KitapDyazarsayisi[i];
                    }
                    else if (KitapDdoktora[i] == 1 && KitapDbolumSayisi[i] > 0 && KitapDyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (8 * KitapDbolumSayisi[i]) / (decimal)KitapDyazarsayisi[i];
                    }
                }
            }

            model.NetPuan = model.HamDoktoraSonrasiPuan + model.HamDoktoraOncesiPuan;

            if (model.NetPuan > 20) model.NetPuan = 20;
            model.BolumAdi = "3. Kitap  ";

            return model;
        }



        #endregion





        #region Patent
        public int[] PatentAdoktora { get; set; } = default!;
        public int[] PatentAsayi { get; set; } = default!;
        public int[] PatentAyazarsayisi { get; set; } = default!;
        public string[] PatentAhatirlatici { get; set; } = default!;

        public int[] PatentBdoktora { get; set; } = default!;
        public int[] PatentBsayi { get; set; } = default!;
        public int[] PatentByazarsayisi { get; set; } = default!;
        public string[] PatentBhatirlatici { get; set; } = default!;

        private Patent PatentHesapla()
        {
            Patent model = new();
            if (PatentAdoktora.Count() > 1)
            {
                for (int i = 1; i < PatentAdoktora.Count(); i++)
                {
                    if (PatentAdoktora[i] == 0 && PatentAsayi[i] > 0 && PatentAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (20 * PatentAsayi[i]) / (decimal)PatentAyazarsayisi[i];
                    }
                    else if (PatentAdoktora[i] == 1 && PatentAsayi[i] > 0 && PatentAyazarsayisi[i] > 0)
                    {
                        model.HamDoktoraSonrasiPuan += (20 * PatentAsayi[i]) / (decimal)PatentAyazarsayisi[i];
                    }
                }

            }
            if (PatentBdoktora.Count() > 1)
            {
                for (int i = 1; i < PatentBdoktora.Count(); i++)
                {
                    if (PatentBdoktora[i] == 0 && PatentBsayi[i] > 0 && PatentByazarsayisi[i] > 0)
                    {
                        model.HamDoktoraOncesiPuan += (10 * PatentBsayi[i]) / (decimal)PatentByazarsayisi[i];
                    }
                    else if (PatentBdoktora[i] == 1 && PatentBsayi[i] > 0 && PatentByazarsayisi[i] > 0)
                    {

                        model.HamDoktoraSonrasiPuan += (10 * PatentBsayi[i]) / (decimal)PatentByazarsayisi[i];
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
                        model.HamDoktoraSonrasiPuan += 4 * DanismanlikAsayi[i];
                    }
                    else if (DanismanlikAsayi[i] > 0 && DanismanlikAseviye[i] == 1)
                    {
                        model.HamDoktoraSonrasiPuan += 2 * DanismanlikAsayi[i];
                    }
                }
            }
            if (DanismanlikBdoktora.Count() > 1)
            {
                for (int i = 1; i < DanismanlikBdoktora.Count(); i++)
                {
                    if (DanismanlikBsayi[i] > 0 && DanismanlikBseviye[i] == 0)
                    {
                        model.HamDoktoraSonrasiPuan += 2 * DanismanlikBsayi[i];
                    }
                    else if (DanismanlikBsayi[i] > 0 && DanismanlikBseviye[i] == 1)
                    {
                        model.HamDoktoraSonrasiPuan += 1 * DanismanlikBsayi[i];
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
        private Egitim EgitimHesapla()
        {
            Egitim model = new();
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
            Makaleler Makaleler = MakalelerHesapla();
            if (Makaleler != null)
            {
                message.ToplamNetPuan += Makaleler.NetPuan;
                message.ToplamDoktoraOncesi += Makaleler.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Makaleler.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Makaleler.BolumAdi,
                    HamDoktoraOncesi = Makaleler.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Makaleler.HamDoktoraSonrasiPuan,
                    NetPuan = Makaleler.NetPuan,
                    Error = Makaleler.Error,
                    ErrorMessage = Makaleler.ErrorMessage
                };
                if (Makaleler.Error == true) message.Error = true;

                message.NetToplamDoktoraSonrasi += Makaleler.HamDoktoraSonrasiPuan;
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
 
                if (Kitap.HamDoktoraSonrasiPuan > 20)
                    message.NetToplamDoktoraSonrasi += 20;
                else message.NetToplamDoktoraSonrasi += Kitap.HamDoktoraSonrasiPuan;
                message.Bolumler.Add(madde);

                message.Bolumler.Add(madde);
            }



            Patent Patent = PatentHesapla();
            if (Patent != null)
            {
                message.ToplamNetPuan += Patent.NetPuan;
                message.ToplamDoktoraOncesi += Patent.HamDoktoraOncesiPuan;
                message.ToplamDoktoraSonrasi += Patent.HamDoktoraSonrasiPuan;
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = Patent.BolumAdi,
                    HamDoktoraOncesi = Patent.HamDoktoraOncesiPuan,
                    HamDoktoraSonrasi = Patent.HamDoktoraSonrasiPuan,
                    NetPuan = Patent.NetPuan,
                    Error = Patent.Error,
                    ErrorMessage = Patent.ErrorMessage
                };
                if (Patent.Error == true) message.Error = true;
                message.NetToplamDoktoraSonrasi += Patent.HamDoktoraSonrasiPuan;
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

             Egitim Egitim = EgitimHesapla();
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

            if (message.NetToplamDoktoraSonrasi < 90 || message.ToplamNetPuan < 100)
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
