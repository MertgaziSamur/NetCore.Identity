using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class UserCreateModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen bir email formatı giriniz.")]
        [Required(ErrorMessage = "Email adresi gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Cinsiyet alanı zorunludur.")]
        public string Gender { get; set; }

    }
}
