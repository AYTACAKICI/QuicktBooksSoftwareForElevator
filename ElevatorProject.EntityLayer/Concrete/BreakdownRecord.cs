using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.EntityLayer.Concrete
{
  public  class BreakdownRecord
    {
        public int BreakdownRecordID { get; set; }
        public int ElevatorID { get; set; }
        public int StaffID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateOfRecord { get; set; }

        public List<Elevator> Elevators { get; set; }
        public List<Staff> Staffs { get; set; }

    }
}
