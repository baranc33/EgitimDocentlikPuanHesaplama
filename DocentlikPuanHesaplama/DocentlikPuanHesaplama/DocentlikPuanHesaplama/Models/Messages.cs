namespace DocentlikPuanHesaplama.Models
{
    public class Messages
    {
        public Messages()
        {
            Bolumler= new();
        }
        public string message { get; set; }
        public List<ListMadde> Bolumler { get; set; }


        public decimal ToplamDoktoraOncesi { get; set; }=0;
        public decimal ToplamDoktoraSonrasi { get; set; } = 0;
        public decimal ToplamNetPuan { get; set; } = 0;

        public int Colum { get; set; } = 9;
        //public string[] ErrorMessage { get; set; }
        public bool Error { get; set; }


    }
}
