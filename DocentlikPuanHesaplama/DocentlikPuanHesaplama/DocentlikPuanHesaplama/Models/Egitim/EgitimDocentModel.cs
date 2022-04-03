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
        public string[]? uluslararasiAhatirlatici { get; set; } = default!;
        private Uluslararasi UluslarArasiHesapla()
        {
            Uluslararasi model = default;
            if (UluslarArasiAdoktora.Count() > 1)
            {


            }



            return model;
        }
        public int[] UluslarArasiBdoktora { get; set; } = default!;
        public int[] UluslarArasiBmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiByazarsayisi { get; set; } = default!;
        public string[]? uluslararasiBhatirlatici { get; set; } = default!;

        public int[] UluslarArasiCdoktora { get; set; } = default!;
        public int[] UluslarArasiCmakalesayisi { get; set; } = default!;
        public int[] UluslarArasiCyazarsayisi { get; set; } = default!;
        public string[]? uluslararasiChatirlatici { get; set; } = default!;




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
            Messages message = default;
            message.Error = true;
            message.ToplamDoktoraOncesi = 0;
            message.ToplamDoktoraSonrasi= 0;
            Uluslararasi uluslararasi = UluslarArasiHesapla();
            if (uluslararasi != default)
            {
                ListMadde madde = new ListMadde()
                {
                    BolumAdi = uluslararasi.BolumAdi,
                    DoktoraOncesi = uluslararasi.HamDoktoraOncesiPuan,
                    DoktoraSonrasi = uluslararasi.HamDoktoraSonrasiPuan,
                    NetPuan = uluslararasi.NetPuan,
                    Sonuc = uluslararasi.Sonuc,
                    ErrorMessage=uluslararasi.ErrorMessage
                };
                if (uluslararasi.Sonuc == false) message.Error = true;
                message.Bolumler.Add(madde);
            }



            message.Colum = message.Bolumler.Count();
            return message;
        }

    }
}
