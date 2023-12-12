using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.EntityLayer.Concrete
{
   public class Offer
    {
        public int OfferID { get; set; }
        public string BuildingName { get; set; }   
        public int? NumberOfFloor { get; set; }
        public string ElevatorType { get; set; }
        public string DoorType { get; set; }
        public string EngineType { get; set; }
        public string ElectronicSystemType { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string Adress3 { get; set; }
        public string Descriptions { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
        public decimal? Price { get; set; }
        public DateTime DateOfRequestForProposal { get; set; }
        public DateTime? DateOfSubmitionOfOffer { get; set; }
    }
}
