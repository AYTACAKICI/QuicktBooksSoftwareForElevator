using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.BuildingManagerDTO
{
   public class BuildingManagerUpdateDto
    {
        public int BuildingManagerID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public int ElevatorID { get; set; }
    }
}
