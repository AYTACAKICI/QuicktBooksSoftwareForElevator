using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.RegisterDTO
{
    public class CreateNewUserDTO
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [MinLength(8,ErrorMessage ="Şifre En Az 8 karakter olmalıdır")]        
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ComfirmPassword { get; set; }
        [Required(ErrorMessage = "Şehir bilginizi giriniz")]
        public string City { get; set; }
        [Required(ErrorMessage = "Cinsiyetinizi giriniz")]
        public string Gender { get; set; }
    }
}
