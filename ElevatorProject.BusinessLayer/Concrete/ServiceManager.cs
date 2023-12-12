﻿using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.BusinessLayer.Concrete
{
   public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _servicesDal;

        public ServiceManager(IServiceDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();
        }

        public Service TInsert(Service t)
        {
            _servicesDal.Insert(t);
            return t;
        }
        public void TUpdate(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
