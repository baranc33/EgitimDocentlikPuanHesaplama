using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class MyMessageDto
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        [MinLength(3, ErrorMessage = "Adınızı Giriniz")]
        public string FullName { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        [MinLength(10, ErrorMessage = "Mail Adresini Giriniz")]
        public string MailAdres { get; set; } = "";
        [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")]
        [MinLength(3, ErrorMessage = "Konu Giriniz")]
        public string Title { get; set; } = "";
        [MaxLength(1000, ErrorMessage = "En Fazla 1000 karakter olabilir")]
        [MinLength(5, ErrorMessage = "Mesajınızı Giriniz")]
        public string Description { get; set; } = "";
    }
}
