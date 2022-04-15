namespace Core.Models.Entities
{
    public class MuhendislikEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";
        public MyUser MyUser { get; set; } = new MyUser();





        #region Makaleler
        public string? MakalelerAdoktora { get; set; }
        public string? MakalelerAmakalesayisi { get; set; }
        public string? MakalelerAyazarsayisi { get; set; }
        public string? MakalelerAsirasi { get; set; }
        public string? MakalelerAhatirlatici { get; set; }
        public string? MakalelerAbasYazar { get; set; }
        public int MakalelerACount { get; set; } = 0;


        public string? MakalelerBdoktora { get; set; }
        public string? MakalelerBmakalesayisi { get; set; }
        public string? MakalelerByazarsayisi { get; set; }
        public string? MakalelerBsirasi { get; set; }
        public string? MakalelerBhatirlatici { get; set; }
        public string? MakalelerBbasYazar { get; set; }
        public int MakalelerBCount { get; set; } = 0;

        public string? MakalelerCdoktora { get; set; }
        public string? MakalelerCmakalesayisi { get; set; }
        public string? MakalelerCyazarsayisi { get; set; }
        public string? MakalelerCsirasi { get; set; }
        public string? MakalelerChatirlatici { get; set; }
        public string? MakalelerCbasYazar { get; set; }
        public int MakalelerCCount { get; set; } = 0;




        #endregion



        #region Yayin
        public string? YayinAdoktora { get; set; }
        public string? YayinAmakalesayisi { get; set; }
        public string? YayinAyazarsayisi { get; set; }
        public string? YayinAsirasi { get; set; }
        public string? YayinAhatirlatici { get; set; }
        public string? YayinAbasYazar { get; set; } = default!;
        public int YayinACount { get; set; } = 0;

        public string? YayinBdoktora { get; set; }
        public string? YayinBmakalesayisi { get; set; }
        public string? YayinBsirasi { get; set; }
        public string? YayinBhatirlatici { get; set; }
        public string? YayinByazarsayisi { get; set; } = default!;
        public string? YayinBbasYazar { get; set; } = default!;
        public int YayinBCount { get; set; } = 0;

        public string? YayinCdoktora { get; set; }
        public string? YayinCbildiri { get; set; }
        public string? YayinCyazarsayisi { get; set; }
        public string? YayinChatirlatici { get; set; }
        public int YayinCCount { get; set; } = 0;

        public string? YayinDdoktora { get; set; }
        public string? YayinDbildiri { get; set; }
        public string? YayinDyazarsayisi { get; set; }
        public string? YayinDhatirlatici { get; set; }
        public int YayinDCount { get; set; } = 0;



        #endregion




        #region Kitap
        public string? KitapAdoktora { get; set; }
        public string? KitapAkitap { get; set; }
        public string? KitapAyazarsayisi { get; set; }
        public string? KitapAhatirlatici { get; set; }
        public int KitapACount { get; set; } = 0;

        public string? KitapBdoktora { get; set; }
        public string? KitapBbolumSayisi { get; set; }
        public string? KitapByazarsayisi { get; set; }
        public string? KitapBhatirlatici { get; set; }
        public int KitapBCount { get; set; } = 0;

        public string? KitapCdoktora { get; set; }
        public string? KitapCkitap { get; set; }
        public string? KitapCyazarsayisi { get; set; }
        public string? KitapChatirlatici { get; set; }
        public int KitapCCount { get; set; } = 0;

        public string? KitapDdoktora { get; set; }
        public string? KitapDbolumSayisi { get; set; }
        public string? KitapDyazarsayisi { get; set; }
        public string? KitapDhatirlatici { get; set; }
        public int KitapDCount { get; set; } = 0;

        #endregion


        #region Patent
        public string? PatentAdoktora { get; set; }
        public string? PatentAsayi { get; set; }
        public string? PatentAyazarsayisi { get; set; }
        public string? PatentAhatirlatici { get; set; }
        public int PatentACount { get; set; } = 0;

        public string? PatentBdoktora { get; set; }
        public string? PatentBsayi { get; set; }
        public string? PatentByazarsayisi { get; set; }
        public string? PatentBhatirlatici { get; set; }
        public int PatentBCount { get; set; } = 0;


        #endregion



        #region Atiflar
        public string? AtiflarAdoktora { get; set; }
        public string? AtiflarAatif { get; set; }
        public string? AtiflarAhatirlatici { get; set; }
        public int AtiflarACount { get; set; } = 0;

        public string? AtiflarBdoktora { get; set; }
        public string? AtiflarBatif { get; set; }
        public string? AtiflarBhatirlatici { get; set; }
        public int AtiflarBCount { get; set; } = 0;

        public string? AtiflarCdoktora { get; set; }
        public string? AtiflarCatif { get; set; }
        public string? AtiflarChatirlatici { get; set; }
        public int AtiflarCCount { get; set; } = 0;
        #endregion




        #region Danismanlik
        // altıncı kısım verileri
        public string? DanismanlikAdoktora { get; set; }
        public string? DanismanlikAseviye { get; set; }
        public string? DanismanlikAsayi { get; set; }
        public string? DanismanlikAhatirlatici { get; set; }
        public int DanismanlikACount { get; set; } = 0;


        public string? DanismanlikBdoktora { get; set; }
        public string? DanismanlikBseviye { get; set; }
        public string? DanismanlikBsayi { get; set; }
        public string? DanismanlikBhatirlatici { get; set; }
        public int DanismanlikBCount { get; set; } = 0;

        #endregion



        #region Arastirma
        public string? ArastirmaAdoktora { get; set; }
        public string? ArastirmaAproje { get; set; }
        public string? ArastirmaAhatirlatici { get; set; }
        public int ArastirmaACount { get; set; } = 0;

        public string? ArastirmaBdoktora { get; set; }
        public string? ArastirmaBproje { get; set; }
        public string? ArastirmaBhatirlatici { get; set; }
        public int ArastirmaBCount { get; set; } = 0;

        public string? ArastirmaCdoktora { get; set; }
        public string? ArastirmaCproje { get; set; }
        public string? ArastirmaChatirlatici { get; set; }
        public int ArastirmaCCount { get; set; } = 0;

        public string? ArastirmaDdoktora { get; set; }
        public string? ArastirmaDproje { get; set; }
        public string? ArastirmaDhatirlatici { get; set; }
        public int ArastirmaDCount { get; set; } = 0;
        #endregion



        #region Toplanti
        public string? ToplantiAdoktora { get; set; }
        public string? ToplantiAsayi { get; set; }
        public string? ToplantiAyazarsayisi { get; set; }
        public string? ToplantiAsirasi { get; set; }
        public string? ToplantiAhatirlatici { get; set; }
        public int ToplantiACount { get; set; } = 0;


        public string? ToplantiBdoktora { get; set; }
        public string? ToplantiBsayi { get; set; }
        public string? ToplantiByazarsayisi { get; set; }
        public string? ToplantiBsirasi { get; set; }
        public string? ToplantiBhatirlatici { get; set; }
        public int ToplantiBCount { get; set; } = 0;

        #endregion




        #region Egitim
        public string? EgitimAdoktora { get; set; }
        public string? EgitimAders { get; set; }
        public string? EgitimAhatirlatici { get; set; }
        public int EgitimACount { get; set; } = 0;

        public string? EgitimBdoktora { get; set; }
        public string? EgitimBders { get; set; }
        public string? EgitimBhatirlatici { get; set; }
        public int EgitimBCount { get; set; } = 0;

        public bool Gorev2yil { get; set; } = false;
        #endregion


    }
}
