namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Egitim : BaseEntity {
        public string BolumAdi { get; set; } = "9. Eğitim-Öğretim Faaliyeti";
        public string ErrorMessage { get; set; } = "";
        public bool Sonuc { get; set; } = false;
    }
}
