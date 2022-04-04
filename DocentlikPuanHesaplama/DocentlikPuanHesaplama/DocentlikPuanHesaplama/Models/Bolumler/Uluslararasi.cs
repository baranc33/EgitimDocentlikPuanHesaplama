namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class UluslarArasi : BaseEntity
    {
        public string BolumAdi { get; set; } = "1. Uluslararası Makale ";
        public string ErrorMessage { get; set; } = "";
        public bool Error { get; set; } = false;

    }
}
