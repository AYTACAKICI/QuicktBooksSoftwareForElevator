using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Concrete;
using ElevatorProject.DataAccessLayer.Repository;
using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
using ElevatorProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DataAccessLayer.EntityFramework
{
    public class EfElevatorDal : GenericRepository<Elevator>, IElevatorDal
    {
        public EfElevatorDal(Context context) : base(context)
        {

        }

        public async Task<List<ResultElevatorDto>> ElevatorDetails()
        {
            var contect = new Context();
            //var values = await (from elevator in contect.Elevators
            //                    join manager in contect.BuildingManagers on elevator.ElevatorID equals manager.ElevatorID
            //                    join maintaince in contect.PeriodicMaintainces  on elevator.ElevatorID equals maintaince.ElevatorID
            //                    join revision in contect.Revisions on elevator.ElevatorID equals revision.ElevatorID
            //                    select new ResultElevatorDto
            //                    {
            //                        ElevatorID = elevator.ElevatorID,
            //                        ElectronicSystemType = elevator.ElectronicSystemType,
            //                        BuildingName = elevator.BuildingName,
            //                        ManufacturedYear = elevator.ManufacturedYear,
            //                        NumberOfFloor = elevator.NumberOfFloor,
            //                        ElevatorType = elevator.ElevatorType,
            //                        ElevatorRegistirationNumber = elevator.ElevatorRegistirationNumber,
            //                        DoorType = elevator.DoorType,
            //                        EngineType = elevator.EngineType,
            //                        Manufacturer = elevator.Manufacturer,
            //                        Adress1 = elevator.Adress1,
            //                        Adress2 = elevator.Adress2,
            //                        Adress3 = elevator.Adress3,
            //                        Descriptions = elevator.Descriptions,
            //                        PeriodicMaintainceID = maintaince.PeriodicMaintainceID,
            //                        RevisionID = revision.RevisionID,
            //                        BuildingManagerID = manager.BuildingManagerID,
            //                        BuildingManagerName = manager.Name,
            //                        BuildingManagerPhone = manager.PhoneNumber,
            //                        LastMaintainceDate = maintaince.MaintainceDate,
            //                        LastRevisionDate = revision.DateOfRevision

            //                    }).ToListAsync();

            var values = await (from elevator in contect.Elevators
                                join manager in contect.BuildingManagers on elevator.ElevatorID equals manager.ElevatorID
                                join maintaince in contect.PeriodicMaintainces on elevator.ElevatorID equals maintaince.ElevatorID into maintainceGroup
                                from maintaince in maintainceGroup.DefaultIfEmpty()  // Left Join
                                join revision in contect.Revisions on elevator.ElevatorID equals revision.ElevatorID into revisionGroup
                                from revision in revisionGroup.DefaultIfEmpty()  // Left Join
                                select new ResultElevatorDto
                                {
                                    ElevatorID = elevator.ElevatorID,
                                    ElectronicSystemType = elevator.ElectronicSystemType,
                                    BuildingName = elevator.BuildingName,
                                    ManufacturedYear = elevator.ManufacturedYear,
                                    NumberOfFloor = elevator.NumberOfFloor,
                                    ElevatorType = elevator.ElevatorType,
                                    ElevatorRegistirationNumber = elevator.ElevatorRegistirationNumber,
                                    DoorType = elevator.DoorType,
                                    EngineType = elevator.EngineType,
                                    Manufacturer = elevator.Manufacturer,
                                    Adress1 = elevator.Adress1,
                                    Adress2 = elevator.Adress2,
                                    Adress3 = elevator.Adress3,
                                    Descriptions = elevator.Descriptions,
                                    PeriodicMaintainceID = maintaince != null ? maintaince.PeriodicMaintainceID : 0,
                                    RevisionID = revision != null ? revision.RevisionID : 0,
                                    BuildingManagerID = manager.BuildingManagerID,
                                    BuildingManagerName = manager.Name,
                                    BuildingManagerPhone = manager.PhoneNumber,
                                    LastMaintainceDate = maintaince != null ? maintaince.MaintainceDate : DateTime.Now,
                                    LastRevisionDate = revision != null ? revision.DateOfRevision : DateTime.Now
                                }).ToListAsync();

            return values;
        }
    }
}
