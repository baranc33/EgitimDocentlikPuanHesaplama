namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Uluslararasi : BaseEntity
    {
        public string BolumAdi { get; set; } = "1. Uluslararası Makale ";
        public string ErrorMessage { get; set; } = "1. Uluslararası Makale maddesinin a veya b bentleri kapsamında en az 20 puan almak zorunludur ";
        public bool Error { get; set; } = false;

    }
}
