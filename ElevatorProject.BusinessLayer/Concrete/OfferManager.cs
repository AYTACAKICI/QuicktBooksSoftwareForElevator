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
   public class OfferManager : IOfferService
    {
        private readonly IOfferDal _offerDal;
        public OfferManager(IOfferDal offerDal)
        {
            _offerDal = offerDal;
        }

        public void TDelete(Offer t)
        {
            _offerDal.Delete(t);
        }

        public Offer TGetByID(int id)
        {
            return _offerDal.GetByID(id);
        }

        public List<Offer> TGetList()
        {
            return _offerDal.GetList();
        }

        public Offer TInsert(Offer t)
        {
            _offerDal.Insert(t);
            return t;
        }

        public void TUpdate(Offer t)
        {
            _offerDal.Update(t);
        }
    }

}
