using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.BreakdownRecordDTO
{
    public class ResultBreakdownRecordDto
    {
        public int BreakdownRecordID { get; set; }
        public int ElevatorID { get; set; }
        public int StaffID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfRecord { get; set; }
    }
}
