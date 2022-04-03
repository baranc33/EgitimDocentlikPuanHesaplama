namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Yayin : BaseEntity {
        public string BolumAdi { get; set; } = "3. Lisansüstü Tezlerden Üretilmiş Yayın";
        public string ErrorMessage { get; set; } = "";
        public bool Sonuc { get; set; } = false;
    }
}
