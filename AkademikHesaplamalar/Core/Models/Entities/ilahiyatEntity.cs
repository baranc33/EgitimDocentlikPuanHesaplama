using System.ComponentModel.DataAnnotations;
namespace Core.Models.Entities
{
    public class ilahiyatEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";
        public MyUser MyUser { get; set; }=new MyUser();

        #region UluslarArasi
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? UluslarArasiAhatirlatici { get; set; }
                public int UluslarArasiACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiByazarsayisi { get; set; }
               [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? UluslarArasiBhatirlatici { get; set; }
                public int UluslarArasiBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? UluslarArasiChatirlatici { get; set; }
                public int UluslarArasiCCount { get; set; } = 0;




        #endregion


        #region Ulusal
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? UlusalAhatirlatici { get; set; }
                public int UlusalACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? UlusalBhatirlatici { get; set; }
                public int UlusalBCount { get; set; } = 0;
        #endregion

        #region Yayin
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinAhatirlatici { get; set; }
                public int YayinACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinBhatirlatici { get; set; }
                public int YayinBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinChatirlatici { get; set; }
                public int YayinCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinDhatirlatici { get; set; }
                public int YayinDCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinEdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinEmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinEyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinEhatirlatici { get; set; }
                public int YayinECount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinFdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinFmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinFyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinFhatirlatici { get; set; }
                public int YayinFCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinGdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinGmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinGyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinGhatirlatici { get; set; }
                public int YayinGCount { get; set; } = 0;
        #endregion



        #region Kitap
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapAhatirlatici { get; set; }
                public int KitapACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapBhatirlatici { get; set; }
                public int KitapBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapChatirlatici { get; set; }
                public int KitapCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapDhatirlatici { get; set; }
                public int KitapDCount { get; set; } = 0;
        #endregion



        #region Atiflar
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarAhatirlatici { get; set; }
                public int AtiflarACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarBhatirlatici { get; set; }
                public int AtiflarBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarChatirlatici { get; set; }
                public int AtiflarCCount { get; set; } = 0;
        #endregion




        #region Danismanlik
        // altıncı kısım verileri
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAsayi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? DanismanlikAhatirlatici { get; set; }
                public int DanismanlikACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBsayi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? DanismanlikBhatirlatici { get; set; }
                public int DanismanlikBCount { get; set; } = 0;

        #endregion



        #region Arastirma
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaAhatirlatici { get; set; }
                public int ArastirmaACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaBhatirlatici { get; set; }
                public int ArastirmaBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaChatirlatici { get; set; }
                public int ArastirmaCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaDhatirlatici { get; set; }
                public int ArastirmaDCount { get; set; } = 0;
        #endregion



        #region Toplanti
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ToplantiAhatirlatici { get; set; }
                public int ToplantiACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ToplantiBhatirlatici { get; set; }
                public int ToplantiBCount { get; set; } = 0;
        #endregion




        #region Egitim
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAders { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? EgitimAhatirlatici { get; set; }
                public int EgitimACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBders { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? EgitimBhatirlatici { get; set; }
                public int EgitimBCount { get; set; } = 0;

                 public bool Gorev2yil { get; set; } = false;
        #endregion


    }
}
