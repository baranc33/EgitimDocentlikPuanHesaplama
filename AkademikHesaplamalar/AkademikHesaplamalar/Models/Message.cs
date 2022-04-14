using System.ComponentModel.DataAnnotations;

namespace AkademikHesaplamalar.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string FullName{ get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string MailAdres { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        public string Title{ get; set; } = "";
        [MaxLength(1000, ErrorMessage = "En Fazla 1000 karakter olabilir")]
        public string Description { get; set; } = "";
    }
}
