namespace AkademikHesaplamalar.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string FullName{ get; set; } = "";
        public string MailAdres { get; set; } = "";
        public string Title{ get; set; } = "";
        public string Description { get; set; } = "";
    }
}
