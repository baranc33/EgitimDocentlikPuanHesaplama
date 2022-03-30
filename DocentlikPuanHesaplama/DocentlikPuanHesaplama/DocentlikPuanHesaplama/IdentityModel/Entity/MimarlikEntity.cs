﻿namespace DocentlikPuanHesaplama.IdentityModel.Entity
{
    public class MimarlikEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";
        public MyUser MyUser { get; set; } = new MyUser();


        #region Makale
        public string? MakaleAdoktora { get; set; }
        public string? MakaleAmakale { get; set; }
        public string? MakaleAyazar { get; set; }
        public string? MakaleAsirasi { get; set; }

        public string? MakaleBdoktora { get; set; }
        public string? MakaleBmakale { get; set; }
        public string? MakaleByazar { get; set; }
        public string? MakaleBsirasi { get; set; }

        public string? MakaleCdoktora { get; set; }
        public string? MakaleCmakale { get; set; }
        public string? MakaleCyazar { get; set; }
        public string? MakaleCsirasi { get; set; }




        #endregion



        #region Yayin
        public string? YayinAdoktora { get; set; }
        public string? YayinAyayin { get; set; }
        public string? YayinAyazar { get; set; }
        public string? YayinAsirasi { get; set; }

        public string? YayinBdoktora { get; set; }
        public string? YayinByayin { get; set; }
        public string? YayinByazar { get; set; }
        public string? YayinBsirasi { get; set; }

        public string? YayinCdoktora { get; set; }
        public string? YayinCyayin { get; set; }
        public string? YayinCyazar { get; set; }
        public string? YayinCsirasi { get; set; }

        public string? YayinDdoktora { get; set; }
        public string? YayinDyayin { get; set; }
        public string? YayinDyazar { get; set; }
        public string? YayinDsirasi { get; set; }



        #endregion




        #region Kitap
        public string? KitapAdoktora { get; set; }
        public string? KitapAkitap { get; set; }
        public string? KitapAyazar { get; set; }
        public string? KitapAsirasi { get; set; }

        public string? KitapBdoktora { get; set; }
        public string? KitapBkitap { get; set; }
        public string? KitapByazar { get; set; }
        public string? KitapBsirasi { get; set; }

        public string? KitapCdoktora { get; set; }
        public string? KitapCkitap { get; set; }
        public string? KitapCyazar { get; set; }
        public string? KitapCsirasi { get; set; }

        public string? KitapDdoktora { get; set; }
        public string? KitapDkitap { get; set; }
        public string? KitapDyazar { get; set; }
        public string? KitapDsirasi { get; set; }

        #endregion


        #region Patent
        public string? PatentAdoktora { get; set; }
        public string? PatentAsayi { get; set; }
        public string? PatentAyazar { get; set; }

        public string? PatentBdoktora { get; set; }
        public string? PatentBsayi { get; set; }
        public string? PatentByazar { get; set; }
        
        public string? PatentCdoktora { get; set; }
        public string? PatentCsayi { get; set; }
        public string? PatentCyazar { get; set; }

        #endregion


        #region Atiflar
        public string? AtiflarAdoktora { get; set; }
        public string? AtiflarAatif { get; set; }

        public string? AtiflarBdoktora { get; set; }
        public string? AtiflarBatif { get; set; }

        public string? AtiflarCdoktora { get; set; }
        public string? AtiflarCatif { get; set; }
        #endregion




        #region Danismanlik
        // altıncı kısım verileri
        public string? DanismanlikAdoktora { get; set; }
        public string? DanismanlikAseviye { get; set; }
        public string? DanismanlikAsayi { get; set; }


        public string? DanismanlikBdoktora { get; set; }
        public string? DanismanlikBseviye { get; set; }
        public string? DanismanlikBsayi { get; set; }

        #endregion



        #region Arastirma
        public string? ArastirmaAdoktora { get; set; }
        public string? ArastirmaAproje { get; set; }

        public string? ArastirmaBdoktora { get; set; }
        public string? ArastirmaBproje { get; set; }

        public string? ArastirmaCdoktora { get; set; }
        public string? ArastirmaCproje { get; set; }

        public string? ArastirmaDdoktora { get; set; }
        public string? ArastirmaDproje { get; set; }
        #endregion



        #region Toplanti
        public string? ToplantiAdoktora { get; set; }
        public string? ToplantiAsayi { get; set; }
        public string? ToplantiAyazar { get; set; }
        public string? ToplantiAsirasi { get; set; }


        public string? ToplantiBdoktora { get; set; }
        public string? ToplantiBsayi { get; set; }
        public string? ToplantiByazar { get; set; }
        public string? ToplantiBsirasi { get; set; }

        #endregion




        #region Egitim
        public string? EgitimAdoktora { get; set; }
        public string? EgitimAders { get; set; }

        public string? EgitimBdoktora { get; set; }
        public string? EgitimBders { get; set; }

        public bool Gorev2yil { get; set; } = false;
        #endregion

    }
}