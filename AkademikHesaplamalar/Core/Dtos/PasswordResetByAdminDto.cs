using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class PasswordResetByAdminDto
    {
        public string UserId { get; set; }

        [Display(Name = "Yeni şifre")]
        public string NewPassword { get; set; }
    }
}
