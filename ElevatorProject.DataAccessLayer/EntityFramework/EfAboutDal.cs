using ElevatorProject.DataAccessLayer.Abstract;
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
   public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
        {

        }
    }
}
