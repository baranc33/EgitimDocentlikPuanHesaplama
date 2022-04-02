namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Toplanti : BaseEntity {
        public string BolumAdi { get; set; } = "8. Bilimsel Toplantı Faaliyeti ";
        public string Message { get; set; } = "";
        public bool Sonuc { get; set; } = false;
    }
}
