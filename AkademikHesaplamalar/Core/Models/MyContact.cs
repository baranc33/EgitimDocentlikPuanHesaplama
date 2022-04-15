using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class MyContact
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string Adres { get; set; } = "";
        [MaxLength(1000, ErrorMessage = "En Fazla 1000 karakter olabilir")]
        public string AdresHtml { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string MailAdres { get; set; } = "";
        [MaxLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string MailExtension { get; set; } = "";
        [MaxLength(15, ErrorMessage = "En Fazla 15 karakter olabilir")]
        public string PhoneNumber { get; set; } = "";
    }
}
