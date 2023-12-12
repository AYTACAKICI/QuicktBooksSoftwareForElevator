using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.BreakdownRecordDTO
{
   public class BreakdownRecordAddDTO
    {
      
        public int ElevatorID { get; set; }
        public int StaffID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfRecord { get; set; }
    }
}
