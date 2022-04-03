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


        public decimal ToplamDoktoraOncesi { get; set; }
        public decimal ToplamDoktoraSonrasi { get; set; }
        public decimal ToplamNetPuan { get; set; }

        public int Colum { get; set; } = 9;
        //public string[] ErrorMessage { get; set; }
        public bool Error { get; set; }


    }
}
