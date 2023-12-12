using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Kullanıcı şifresini giriniz")]

        public string Password { get; set; }
    }
}
