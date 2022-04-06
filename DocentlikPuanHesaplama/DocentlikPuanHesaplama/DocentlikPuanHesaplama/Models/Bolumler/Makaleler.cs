namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Makaleler : BaseEntity
    {
        public string BolumAdi { get; set; } = "9. Eğitim-Öğretim Faaliyeti";
        public string ErrorMessage { get; set; } = "";
        public bool Error { get; set; } = false;
    }
}
