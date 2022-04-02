namespace DocentlikPuanHesaplama.Models
{
    public class Messages
    {
        public string message { get; set; }
        public List<ListMadde> maddeler { get; set; }


        public string ToplamDoktoraOncesi { get; set; }
        public string ToplamDoktoraSonrasi { get; set; }
        public string ToplamNetPuan { get; set; }

        public int Colum { get; set; } = 9;
        public string[] ErrorMessage { get; set; } 
        

    }
    public class ListMadde
    {
        public string MaddeAdi { get; set; }
        public string DoktoraOncesi { get; set; }
        public string DoktoraSonrasi { get; set; }
        public string NetPuan { get; set; }

    }
}
