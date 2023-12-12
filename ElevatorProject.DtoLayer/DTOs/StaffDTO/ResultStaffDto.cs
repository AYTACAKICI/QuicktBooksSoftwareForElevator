using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.StaffDTO
{
   public class ResultStaffDto
    {
        public int StaffID { get; set; }       
        public string Name { get; set; }      
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
