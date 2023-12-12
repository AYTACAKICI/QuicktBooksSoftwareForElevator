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
   public class RevisionManager : IRevisionService
    {
        private readonly IRevisionDal _revisionDal;
        public RevisionManager(IRevisionDal revisionDal)
        {
            _revisionDal = revisionDal;
        }

        public void TDelete(Revision t)
        {
            _revisionDal.Delete(t);
        }

        public Revision TGetByID(int id)
        {
            return _revisionDal.GetByID(id);
        }

        public List<Revision> TGetList()
        {
            return _revisionDal.GetList();
        }

        public Revision TInsert(Revision t)
        {
            _revisionDal.Insert(t);
            return t;
        }

        public void TUpdate(Revision t)
        {
            _revisionDal.Update(t);
        }
    }
}
