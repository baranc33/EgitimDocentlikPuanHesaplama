namespace DocentlikPuanHesaplama.Models
{
    public class BaseEntity
    {
        public decimal NetPuan { get; set; } = 0;
        public decimal HamDoktoraOncesiPuan { get; set; } = 0;
        public decimal HamDoktoraSonrasiPuan { get; set; } = 0;

    }
}
