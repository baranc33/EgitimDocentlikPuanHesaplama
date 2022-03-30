using DocentlikPuanHesaplama.Models.Egitim.Bolumler;

namespace DocentlikPuanHesaplama.Models.Egitim
{
    public class EgitimAnswerModel
    {
        public void TotalAnswer()
        {
            TotalPuan = 0;
            DoktoraOncesi = 0;

            DoktoraSonrasi = 0;
        }

        public decimal DoktoraOncesi { get; set; }
        public decimal DoktoraSonrasi { get; set; }
        public decimal TotalPuan { get; set; }
        public Uluslararasi Uluslararasi { get; set; }=new Uluslararasi();
        public Ulusal Ulusal { get; set; }=new  Ulusal();
        //public UcAnswerModel ucAnswerModel { get; set; }
        //public DortAnswerModel dortAnswerModel { get; set; }
        //public BesAnswerModel besAnswerModel { get; set; }
        //public AltiAnswerModel altiAnswerModel { get; set; }
        //public YediAnswerModel yediAnswerModel { get; set; }
        //public DokuzAnswerModel dokuzAnswerModel { get; set; }
        //public SekizAnswerModel sekizAnswerModel { get; set; }
    }
}
