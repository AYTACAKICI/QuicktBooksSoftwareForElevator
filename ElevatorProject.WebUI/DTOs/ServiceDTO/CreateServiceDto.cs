using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.ServiceDTO
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Service ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı en fazla 100 karakter olabilir")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
