namespace DocentlikPuanHesaplama.Models
{
    public class ListMadde
    {
        public string BolumAdi { get; set; }
        public decimal HamDoktoraOncesi { get; set; }
        public decimal HamDoktoraSonrasi { get; set; }
        public decimal NetPuan { get; set; }
        public bool Error { get; set; }
        public string ErrorMessage{ get; set; }


    }
}
