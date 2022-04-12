namespace AkademikHesaplamalar.ViewModels.DocentModels
{
    public class Messages
    {
        public Messages()
        {
            Bolumler= new();
        }
        public string message { get; set; }
        public List<ListMadde> Bolumler { get; set; }


        public decimal ToplamDoktoraOncesi { get; set; } = 0;
        public decimal ToplamDoktoraSonrasi { get; set; } = 0;
        public decimal NetToplamDoktoraSonrasi { get; set; } = 0;
        public decimal ToplamNetPuan { get; set; } = 0;
        public string AsgariMessage { get; set; }

        public int Colum { get; set; } = 9;
        public bool Error { get; set; }


    }
}
