namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Uluslararasi : BaseEntity
    {
        public string BolumAdi { get; set; } = "1. Uluslararası Makale ";
        public string ErrorMessage { get; set; } = "";
        public bool Sonuc { get; set; } = false;

    }
}
