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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;
        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest TGetByID(int id)
        {
            return _guestDal.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public Guest TInsert(Guest t)
        {
            _guestDal.Insert(t);
            return t;
        }

        public void TUpdate(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
