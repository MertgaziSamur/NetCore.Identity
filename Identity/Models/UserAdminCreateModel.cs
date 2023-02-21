using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class UserAdminCreateModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail adresi gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet belirtiniz.")]
        public string Gender { get; set; }

    }
}
