using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.BusinessLayer.Concrete
{
  public class ElevatorManager : IElevatorService
    {
        private readonly IElevatorDal _elevatorDal;
        public ElevatorManager(IElevatorDal elevatorDal)
        {
            _elevatorDal = elevatorDal;
        }

        public void TDelete(Elevator t)
        {
            _elevatorDal.Delete(t);
        }

        public Task<List<ResultElevatorDto>> TElevatorDetails()
        {
          return  _elevatorDal.ElevatorDetails();
        }

        public Elevator TGetByID(int id)
        {
            return _elevatorDal.GetByID(id);
        }

        public List<Elevator> TGetList()
        {
            return _elevatorDal.GetList();
        }

        public Elevator TInsert(Elevator t)
        {
            _elevatorDal.Insert(t);
            return t;
        }

        public void TUpdate(Elevator t)
        {
            _elevatorDal.Update(t);
        }
    }
}
