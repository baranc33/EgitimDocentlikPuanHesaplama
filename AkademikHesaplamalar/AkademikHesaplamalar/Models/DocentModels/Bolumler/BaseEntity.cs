namespace AkademikHesaplamalar.Models.DocentModels.Bolumler
{
    public class BaseEntity
    {
        public decimal NetPuan { get; set; } = 0;
        public decimal HamDoktoraOncesiPuan { get; set; } = 0;
        public decimal HamDoktoraSonrasiPuan { get; set; } = 0;
        public string ErrorMessage { get; set; } = "";


    }
}
