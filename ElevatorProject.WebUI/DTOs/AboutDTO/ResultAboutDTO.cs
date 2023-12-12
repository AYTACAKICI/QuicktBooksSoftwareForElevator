using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.AboutDTO
{
    public class ResultAboutDTO
    {
        public int AboutID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int ElevatorCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
