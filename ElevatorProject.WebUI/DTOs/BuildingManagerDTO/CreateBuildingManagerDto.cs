using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.BuildingManagerDTO
{
    public class CreateBuildingManagerDto
    {
      
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public int ElevatorID { get; set; }
    }
}
