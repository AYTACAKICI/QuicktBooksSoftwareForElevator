using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.StaffDTO
{
   public class StaffAddDto
    {
        [Required(ErrorMessage = "Lütfen Personel Adını Yazınız")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Personel Soyadını Yazınız")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Personel Ünvanını Yazınız")]
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
