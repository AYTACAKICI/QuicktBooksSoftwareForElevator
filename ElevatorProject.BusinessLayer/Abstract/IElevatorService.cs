using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.BusinessLayer.Abstract
{
   public interface IElevatorService : IGenericService<Elevator>
    {
        Task<List<ResultElevatorDto>> TElevatorDetails();
    }
}
