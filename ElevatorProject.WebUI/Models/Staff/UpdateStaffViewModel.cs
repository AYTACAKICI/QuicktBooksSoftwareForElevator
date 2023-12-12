using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Models.Staff
{
    public class UpdateStaffViewModel
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
