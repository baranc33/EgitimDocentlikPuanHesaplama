namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Kitap : BaseEntity {
        public string BolumAdi { get; set; } = "4. Kitap ";
        public string ErrorMessage { get; set; } = "";
        public bool Error { get; set; } = false;
    }
}
