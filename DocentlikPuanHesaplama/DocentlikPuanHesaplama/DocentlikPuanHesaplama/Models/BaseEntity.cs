namespace DocentlikPuanHesaplama.Models
{
    public class BaseEntity
    {
        public decimal NetTotalPuan { get; set; } = 0;
        public decimal HamTotalDoktoraOncesiPuan { get; set; } = 0;
        public decimal HamTotalDoktoraSonrasiPuan { get; set; } = 0;

    }
}
