using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.PeriodicMaintainceDTO
{
   public class PeriodicMaintainceUpdateDto
    {
        public int PeriodicMaintainceID { get; set; }
        public int ElevatorID { get; set; }
        public int StaffID { get; set; }
        public string PeriodOfMonthAndYear { get; set; }
        public DateTime MaintainceDate { get; set; }
        public int ChargedPrice { get; set; }
        public string Description { get; set; }
    }
}
