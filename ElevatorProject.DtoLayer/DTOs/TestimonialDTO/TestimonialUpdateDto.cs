using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.TestimonialDTO
{
   public class TestimonialUpdateDto
    {
        public int TestimonialID { get; set; }
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string Name { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Olumlu/Olumsuz Referanslarınızı Giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karater veri girişi yapınız")]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
