using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.EntityLayer.Concrete
{
   public class Staff
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public List<PeriodicMaintaince> PeriodicMaintainces { get; set; }
        public List<BreakdownRecord> BreakdownRecords { get; set; }
    }
}
