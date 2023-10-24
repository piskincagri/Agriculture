using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz!")]
        [Compare("password",ErrorMessage = "Girdiğiniz şifreler uyumlu değildir. Lütfen kontrol ediniz!")]
        public string passwordConfirm { get; set; }

    }
}
