namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Danismanlik : BaseEntity {
        public string BolumAdi { get; set; } = "6. Lisansüstü Tez Danışmanlığı";
        public string ErrorMessage { get; set; } = "";
        // hata varmı Anlamında false ise hata yok
        public bool Error { get; set; } = false;

    }
}
