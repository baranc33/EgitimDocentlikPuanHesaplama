namespace AkademikHesaplamalar.Models
{
    public class AdminMember
    {
        public int Id{ get; set; }
        public int IdRow { get; set; }
        public string FullName{ get; set; } = "";
        public string Degree { get; set; } = "";// ünvan
        public string Github{ get; set; } = "";
        public string Linkedin { get; set; } = "";
        public string Instegram{ get; set; } = "";
        public string Facebook{ get; set; } = "";
        public string Description{ get; set; } = "";
        public string MailAdres{ get; set; } = "";
        public string MailExtension{ get; set; } = "";
        public string WebSiteUrl{ get; set; } = "";
        public string İmage{ get; set; } = "";
    }
}
