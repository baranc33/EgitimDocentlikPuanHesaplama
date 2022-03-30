namespace DocentlikPuanHesaplama.Models.Egitim
{
    public class EgitimDocentModel
    {
        public int Id{ get; set; }
        //public string? MyUserId { get; set; }

        public int UluslarArasiAdoktora { get; set; }
        public int UluslarArasiAmakale { get; set; }
        public int UluslarArasiAyazar { get; set; }











        public decimal NetTotalPuan { get; set; } = 0;
        public decimal HamTotalDoktoraOncesiPuan { get; set; } = 0;
        public decimal HamTotalDoktoraSonrasiPuan { get; set; } = 0;

        public string? Message { get; set; } = "";
        public bool Sonuc { get; set; } = false;

        public void Hesapla()
        {

        }

    }
}
