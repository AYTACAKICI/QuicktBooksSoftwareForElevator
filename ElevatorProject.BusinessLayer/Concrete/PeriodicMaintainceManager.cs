using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.BusinessLayer.Concrete
{
   public class PeriodicMaintainceManager : IPeriodicMaintainceService
    {
        private readonly IPeriodicMaintainceDal _periodicMaintaince;
        public PeriodicMaintainceManager(IPeriodicMaintainceDal periodicMaintaince)
        {
            _periodicMaintaince = periodicMaintaince;
        }

        public void TDelete(PeriodicMaintaince t)
        {
            _periodicMaintaince.Delete(t);
        }

        public PeriodicMaintaince TGetByID(int id)
        {
            return _periodicMaintaince.GetByID(id);
        }

        public List<PeriodicMaintaince> TGetList()
        {
            return _periodicMaintaince.GetList();
        }

        public PeriodicMaintaince TInsert(PeriodicMaintaince t)
        {
            _periodicMaintaince.Insert(t);
            return t;
        }

        public void TUpdate(PeriodicMaintaince t)
        {
            _periodicMaintaince.Update(t);
        }
    }
}
