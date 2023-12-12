using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DtoLayer.DTOs.RevisionDTO
{
   public class RevisionUpdateDto
    {
        public int RevisionID { get; set; }
        public int ElevatorID { get; set; }
        public DateTime DateOfRevision { get; set; }
        public DateTime OfferSubmissionDate { get; set; }
        public int PriceOfOffer { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
