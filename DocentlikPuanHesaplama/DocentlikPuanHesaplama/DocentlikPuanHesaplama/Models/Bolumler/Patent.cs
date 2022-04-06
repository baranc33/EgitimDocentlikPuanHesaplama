namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Patent : BaseEntity
    {
        public string BolumAdi { get; set; } = "4. Patent";
        public string ErrorMessage { get; set; } = "";
        public bool Error { get; set; } = false;
    }
}
