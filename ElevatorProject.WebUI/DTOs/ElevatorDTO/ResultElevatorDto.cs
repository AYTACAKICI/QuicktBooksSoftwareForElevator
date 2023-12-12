using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.ElevatorDTO
{
    public class ResultElevatorDto
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
        public int PeriodicMaintainceID { get; set; }
        public int RevisionID { get; set; }
        public int BuildingManagerID { get; set; }
        public string BuildingManagerName { get; set; }
        public string BuildingManagerPhone { get; set; }
        public DateTime LastMaintainceDate { get; set; }
        public DateTime LastRevisionDate { get; set; }

    }
}
