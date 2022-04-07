namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Sinema : BaseEntity
    {
        public string BolumAdi { get; set; } = "1. Sinema, Plastik Sanatlar, Tasarım, Geleneksel Türk Sanatları, Taşınabilir Kültür Varlıkları / Sanat Eserleri Restorasyonu ve Konservasyonu ";
        public string ErrorMessage { get; set; } = "I. Madde 40 , II. Madde 10 ,III. Madde 15,IV madde 25 , V Madde 10  olmaldır  bu puanların 90 ı Doktora Sonrası olmalıdır";
        public bool Error { get; set; } = false;
    }
}
