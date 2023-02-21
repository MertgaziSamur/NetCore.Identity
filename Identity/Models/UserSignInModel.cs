using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Lütfen kayıtlı bir kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
