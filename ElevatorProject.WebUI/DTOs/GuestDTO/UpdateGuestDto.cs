using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.GuestDTO
{
    public class UpdateGuestDto
    {
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
