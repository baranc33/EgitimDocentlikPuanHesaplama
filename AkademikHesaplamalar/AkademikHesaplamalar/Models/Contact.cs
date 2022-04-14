namespace AkademikHesaplamalar.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Adres{ get; set; } = "";
        public string AdresHtml { get; set; } = "";
        public string MailAdres { get; set; } = "";
        public string MailExtension { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
    }
}
