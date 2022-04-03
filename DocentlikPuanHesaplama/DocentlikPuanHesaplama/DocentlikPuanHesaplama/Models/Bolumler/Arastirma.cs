namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Arastirma : BaseEntity {
        public string BolumAdi { get; set; } = "7. Bilimsel Araştırma Projesi";
        public string ErrorMessage { get; set; } = "";
        public bool Sonuc { get; set; } = false;
    }
}
