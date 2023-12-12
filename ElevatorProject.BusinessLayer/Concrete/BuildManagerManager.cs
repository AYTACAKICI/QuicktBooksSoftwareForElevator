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
   public class BuildManagerManager : IBuildingManagerService
    {
        private readonly IBuildingManagerDal _buildingManagerDal;
        public BuildManagerManager(IBuildingManagerDal buildingManagerDal)
        {
            _buildingManagerDal = buildingManagerDal;
        }

        public void TDelete(BuildingManager t)
        {
            _buildingManagerDal.Delete(t);
        }

        public BuildingManager TGetByID(int id)
        {
            return _buildingManagerDal.GetByID(id);
        }

        public List<BuildingManager> TGetList()
        {
            return _buildingManagerDal.GetList();
        }

        public BuildingManager TInsert(BuildingManager t)
        {
            _buildingManagerDal.Insert(t);
            return t;
        }

        public void TUpdate(BuildingManager t)
        {
            _buildingManagerDal.Update(t);
        }
    }
}
