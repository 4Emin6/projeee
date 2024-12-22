using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeee.Models
{
    public class RegisterViewModel
    {
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public string ParolaTekrar { get; set; } // Şifre doğrulama için

        
    }
}