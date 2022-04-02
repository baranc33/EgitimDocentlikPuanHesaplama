namespace DocentlikPuanHesaplama.IdentityModel.Entity
{
    public class SporEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";
        public MyUser MyUser { get; set; }=new MyUser();


        #region UluslarArasi
        public string? UluslarArasiAdoktora { get; set; }
        public string? UluslarArasiAmakalesayisi { get; set; }
        public string? UluslarArasiAyazarsayisi { get; set; }
        public string? UluslarArasiAsirasi { get; set; }
        public string? UluslarArasiAhatirlatici { get; set; }

        public string? UluslarArasiBdoktora { get; set; }
        public string? UluslarArasiBmakalesayisi { get; set; }
        public string? UluslarArasiByazarsayisi { get; set; }
        public string? UluslarArasiBsirasi { get; set; }
        public string? UluslarArasiBhatirlatici { get; set; }

        public string? UluslarArasiCdoktora { get; set; }
        public string? UluslarArasiCmakalesayisi { get; set; }
        public string? UluslarArasiCyazarsayisi { get; set; }
        public string? UluslarArasiCsirasi { get; set; }
        public string? UluslarArasiChatirlatici { get; set; }

     


        #endregion


        #region Ulusal
        public string? UlusalAdoktora { get; set; }
        public string? UlusalAmakalesayisi { get; set; }
        public string? UlusalAyazarsayisi { get; set; }
        public string? UlusalAsirasi { get; set; }
        public string? UlusalAhatirlatici { get; set; }


        public string? UlusalBdoktora { get; set; }
        public string? UlusalBmakalesayisi { get; set; }
        public string? UlusalByazarsayisi { get; set; }
        public string? UlusalBsirasi { get; set; }
        public string? UlusalBhatirlatici { get; set; }

        #endregion


        #region Yayin
        public string? YayinAdoktora { get; set; }
        public string? YayinAyayin { get; set; }
        public string? YayinAyazarsayisi { get; set; }
        public string? YayinAsirasi { get; set; }
        public string? YayinAhatirlatici { get; set; }

        public string? YayinBdoktora { get; set; }
        public string? YayinByayin { get; set; }
        public string? YayinByazarsayisi { get; set; }
        public string? YayinBsirasi { get; set; }
        public string? YayinBhatirlatici { get; set; }

        public string? YayinCdoktora { get; set; }
        public string? YayinCyayin { get; set; }
        public string? YayinCyazarsayisi { get; set; }
        public string? YayinCsirasi { get; set; }
        public string? YayinChatirlatici { get; set; }

        public string? YayinDdoktora { get; set; }
        public string? YayinDyayin { get; set; }
        public string? YayinDyazarsayisi { get; set; }
        public string? YayinDsirasi { get; set; }
        public string? YayinDhatirlatici { get; set; }

        public string? YayinEdoktora { get; set; }
        public string? YayinEyayin { get; set; }
        public string? YayinEyazarsayisi { get; set; }
        public string? YayinEsirasi { get; set; }
        public string? YayinEhatirlatici { get; set; }

        public string? YayinFdoktora { get; set; }
        public string? YayinFyayin { get; set; }
        public string? YayinFyazarsayisi { get; set; }
        public string? YayinFsirasi { get; set; }
        public string? YayinFhatirlatici { get; set; }

        public string? YayinGdoktora { get; set; }
        public string? YayinGyayin { get; set; }
        public string? YayinGyazarsayisi { get; set; }
        public string? YayinGsirasi { get; set; }
        public string? YayinGhatirlatici { get; set; }

        #endregion


        #region Kitap
        public string? KitapAdoktora { get; set; }
        public string? KitapAkitap { get; set; }
        public string? KitapAyazarsayisi { get; set; }
        public string? KitapAsirasi { get; set; }
        public string? KitapAhatirlatici { get; set; }

        public string? KitapBdoktora { get; set; }
        public string? KitapBkitap { get; set; }
        public string? KitapByazarsayisi { get; set; }
        public string? KitapBsirasi { get; set; }
        public string? KitapBhatirlatici { get; set; }

        public string? KitapCdoktora { get; set; }
        public string? KitapCkitap { get; set; }
        public string? KitapCyazarsayisi { get; set; }
        public string? KitapCsirasi { get; set; }
        public string? KitapChatirlatici { get; set; }

        public string? KitapDdoktora { get; set; }
        public string? KitapDkitap { get; set; }
        public string? KitapDyazarsayisi { get; set; }
        public string? KitapDsirasi { get; set; }
        public string? KitapDhatirlatici { get; set; }

        #endregion


        #region Atiflar
        public string? AtiflarAdoktora { get; set; }
        public string? AtiflarAatif { get; set; }
        public string? AtiflarAhatirlatici { get; set; }

        public string? AtiflarBdoktora { get; set; }
        public string? AtiflarBatif { get; set; }
        public string? AtiflarBhatirlatici { get; set; }

        public string? AtiflarCdoktora { get; set; }
        public string? AtiflarCatif { get; set; }
        public string? AtiflarChatirlatici { get; set; }
        #endregion



        #region Danismanlik
        // altıncı kısım verileri
        public string? DanismanlikAdoktora { get; set; }
        public string? DanismanlikAseviye { get; set; }
        public string? DanismanlikAsayi { get; set; }
        public string? DanismanlikAhatirlatici { get; set; }


        public string? DanismanlikBdoktora { get; set; }
        public string? DanismanlikBseviye { get; set; }
        public string? DanismanlikBsayi { get; set; }
        public string? DanismanlikBhatirlatici { get; set; }

        #endregion



        #region Arastirma
        public string? ArastirmaAdoktora { get; set; }
        public string? ArastirmaAproje { get; set; }
        public string? ArastirmaAhatirlatici { get; set; }

        public string? ArastirmaBdoktora { get; set; }
        public string? ArastirmaBproje { get; set; }
        public string? ArastirmaBhatirlatici { get; set; }

        public string? ArastirmaCdoktora { get; set; }
        public string? ArastirmaCproje { get; set; }
        public string? ArastirmaChatirlatici { get; set; }

        public string? ArastirmaDdoktora { get; set; }
        public string? ArastirmaDproje { get; set; }
        public string? ArastirmaDhatirlatici { get; set; }
        #endregion



        #region Toplanti
        public string? ToplantiAdoktora { get; set; }
        public string? ToplantiAsayi { get; set; }
        public string? ToplantiAyazarsayisi { get; set; }
        public string? ToplantiAsirasi { get; set; }
        public string? ToplantiAhatirlatici { get; set; }


        public string? ToplantiBdoktora { get; set; }
        public string? ToplantiBsayi { get; set; }
        public string? ToplantiByazarsayisi { get; set; }
        public string? ToplantiBsirasi { get; set; }
        public string? ToplantiBhatirlatici { get; set; }

        #endregion


        #region Egitim
        public string? EgitimAdoktora { get; set; }
        public string? EgitimAders { get; set; }
        public string? EgitimAhatirlatici { get; set; }

        public string? EgitimBdoktora { get; set; }
        public string? EgitimBders { get; set; }
        public string? EgitimBhatirlatici { get; set; }

        public bool Gorev2yil { get; set; } = false;
        #endregion

    }
}
