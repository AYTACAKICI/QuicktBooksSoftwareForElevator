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
   public class BreakdownRecordManager : IBreakdownRecordService
    {
        private readonly IBreakdownRecordDal _breakdownRecordDal;
        public BreakdownRecordManager(IBreakdownRecordDal breakdownRecordDal)
        {
            _breakdownRecordDal = breakdownRecordDal;
        }

        public void TDelete(BreakdownRecord t)
        {
            _breakdownRecordDal.Delete(t);
        }

        public BreakdownRecord TGetByID(int id)
        {
            return _breakdownRecordDal.GetByID(id);
        }

        public List<BreakdownRecord> TGetList()
        {
            return _breakdownRecordDal.GetList();
        }

        public BreakdownRecord TInsert(BreakdownRecord t)
        {
            _breakdownRecordDal.Insert(t);
            return t;
        }

        public void TUpdate(BreakdownRecord t)
        {
            _breakdownRecordDal.Update(t);
        }
    }
}
