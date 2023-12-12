using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DataAccessLayer.Abstract
{
   public interface IElevatorDal:IGenericDal<Elevator>
    {
        Task<List<ResultElevatorDto>> ElevatorDetails();
    }
}
