namespace DocentlikPuanHesaplama.IdentityModel.Entity
{
    public class HukunEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; }
        public MyUser MyUser { get; set; }

        #region UluslarArasi
        public string? UluslarArasiAdoktora { get; set; }
        public string? UluslarArasiAmakale { get; set; }
        public string? UluslarArasiAyazar { get; set; }

        public string? UluslarArasiBdoktora { get; set; }
        public string? UluslarArasiBmakale { get; set; }
        public string? UluslarArasiByazar { get; set; }

        public string? UluslarArasiCdoktora { get; set; }
        public string? UluslarArasiCmakale { get; set; }
        public string? UluslarArasiCyazar { get; set; }




        #endregion


        #region Ulusal
        public string? UlusalAdoktora { get; set; }
        public string? UlusalAmakale { get; set; }
        public string? UlusalAyazar { get; set; }


        public string? UlusalBdoktora { get; set; }
        public string? UlusalBmakale { get; set; }
        public string? UlusalByazar { get; set; }
        #endregion


        #region Yayin
        public string? YayinAdoktora { get; set; }
        public string? YayinAyayin { get; set; }
        public string? YayinAyazar { get; set; }

        public string? YayinBdoktora { get; set; }
        public string? YayinByayin { get; set; }
        public string? YayinByazar { get; set; }

        public string? YayinCdoktora { get; set; }
        public string? YayinCyayin { get; set; }
        public string? YayinCyazar { get; set; }

        public string? YayinDdoktora { get; set; }
        public string? YayinDyayin { get; set; }
        public string? YayinDyazar { get; set; }

        public string? YayinEdoktora { get; set; }
        public string? YayinEyayin { get; set; }
        public string? YayinEyazar { get; set; }

        public string? YayinFdoktora { get; set; }
        public string? YayinFyayin { get; set; }
        public string? YayinFyazar { get; set; }

        public string? YayinGdoktora { get; set; }
        public string? YayinGyayin { get; set; }
        public string? YayinGyazar { get; set; }
        #endregion



        #region Kitap
        public string? KitapAdoktora { get; set; }
        public string? KitapAkitap { get; set; }
        public string? KitapAyazar { get; set; }

        public string? KitapBdoktora { get; set; }
        public string? KitapBkitap { get; set; }
        public string? KitapByazar { get; set; }

        public string? KitapCdoktora { get; set; }
        public string? KitapCkitap { get; set; }
        public string? KitapCyazar { get; set; }

        public string? KitapDdoktora { get; set; }
        public string? KitapDkitap { get; set; }
        public string? KitapDyazar { get; set; }
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


        public string? ToplantiBdoktora { get; set; }
        public string? ToplantiBsayi { get; set; }
        public string? ToplantiByazar { get; set; }
        #endregion




        #region Egitim
        public string? EgitimAdoktora { get; set; }
        public string? EgitimAders { get; set; }

        public string? EgitimBdoktora { get; set; }
        public string? EgitimBders { get; set; }

        public bool gorev2yil { get; set; } = false;
        #endregion


    }
}
