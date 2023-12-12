﻿using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Concrete;
using ElevatorProject.DataAccessLayer.Repository;
using ElevatorProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }
    }
}
