using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.EntityLayer.Concrete
{
   public class Elevator
    {
        public int ElevatorID { get; set; }
        public string ElevatorRegistirationNumber { get; set; }
        public string BuildingName { get; set; }
        public int ManufacturedYear { get; set; }
        public int NumberOfFloor { get; set; }
        public string ElevatorType { get; set; }
        public string DoorType { get; set; }
        public string EngineType { get; set; }
        public string Manufacturer { get; set; }
        public string ElectronicSystemType { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string Adress3 { get; set; }
        public string Descriptions { get; set; }
       


        public BuildingManager BuildingManager { get; set; }
        public List<PeriodicMaintaince> PeriodicMaintainces { get; set; }
        public List<BreakdownRecord> BreakdownRecords { get; set; }
        public List<Revision> Revisions { get; set; }

    }
}
