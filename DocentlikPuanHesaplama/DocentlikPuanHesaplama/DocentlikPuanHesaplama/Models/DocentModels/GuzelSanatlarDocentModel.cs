using DocentlikPuanHesaplama.IdentityModel;

namespace DocentlikPuanHesaplama.Models.DocentModels
{
    public class GuzelSanatlarDocentModel
    {
        public int? Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;
        public MyUser? MyUser { get; set; } = default!;


        #region Sinama

        public int[] SinamaIDoktora { get; set; } = default!;
        public int[] SinamaIEtkinlikSayisi { get; set; } = default!;


        public int[] SinamaIIDoktora { get; set; } = default!;
        public int[] SinamaIIEtkinlikSayisi { get; set; } = default!;

        public int[] SinamaIIIDoktora { get; set; } = default!;
        public int[] SinamaIIIEtkinlikSayisi { get; set; } = default!;


        public int[] SinamaIVDoktora { get; set; } = default!;
        public int[] SinamaIVEtkinlikSayisi { get; set; } = default!;
        public int[] SinamaIVTur { get; set; } = default!; /* kitap 12.5  // kitapçeviri 6.25 //    makale 6.25  / makale çeviri 6.25*/



        public int[] SinamaVDoktora { get; set; } = default!;
        public int[] SinamaV { get; set; } = default!;




        /*
         I- 40
        III 15
        IV-25
        II -10 
        V - 10
        TOPLAM 100  - 90 SI doktora sonrası
         */
        #endregion






        #region Muzik
        /*Bütün şartlar zorunludur*/


        #endregion


    }
}
