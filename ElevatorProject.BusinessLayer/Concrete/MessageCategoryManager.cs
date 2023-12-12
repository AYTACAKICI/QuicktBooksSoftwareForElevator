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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;
        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public MessageCategory TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public MessageCategory TInsert(MessageCategory t)
        {
            _messageCategoryDal.Insert(t);
            return t;
        }

        public void TUpdate(MessageCategory t)
        {
            throw new NotImplementedException();
        }
    }
}
