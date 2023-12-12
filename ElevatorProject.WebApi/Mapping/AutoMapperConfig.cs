using AutoMapper;
using ElevatorProject.DtoLayer.DTOs.AboutDTO;
using ElevatorProject.DtoLayer.DTOs.BreakdownRecordDTO;
using ElevatorProject.DtoLayer.DTOs.BuildingManagerDTO;
using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
using ElevatorProject.DtoLayer.DTOs.GuestDTO;
using ElevatorProject.DtoLayer.DTOs.OfferDTO;
using ElevatorProject.DtoLayer.DTOs.PeriodicMaintainceDTO;
using ElevatorProject.DtoLayer.DTOs.RevisionDTO;
using ElevatorProject.DtoLayer.DTOs.SendMessageDto;
using ElevatorProject.DtoLayer.DTOs.ServiceDTO;
using ElevatorProject.DtoLayer.DTOs.StaffDTO;
using ElevatorProject.DtoLayer.DTOs.TestimonialDTO;
using ElevatorProject.EntityLayer.Concrete;
using ElevatorProject.WebUI.DTOs.ElevatorDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<AboutAddDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<ServiceAddDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();


            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<StaffAddDto, Staff>().ReverseMap();
            CreateMap<StaffUpdateDto, Staff>().ReverseMap();

            CreateMap<BreakdownRecordAddDTO, BreakdownRecord>().ReverseMap();
            CreateMap<BreakdownRecordUpdateDto, BreakdownRecord>().ReverseMap();

            CreateMap<BuildingManagerAddDto, BuildingManager>().ReverseMap();
            CreateMap<BuildingManagerUpdateDto, BuildingManager>().ReverseMap();

            CreateMap<ElevatorAddDto, Elevator>().ReverseMap();
            CreateMap<ElevatorUpdateDto, Elevator>().ReverseMap();

            CreateMap<PeriodicMaintainceAddDto, PeriodicMaintaince>().ReverseMap();
            CreateMap<PeriodicMaintainceUpdateDto, PeriodicMaintaince>().ReverseMap();

            CreateMap<TestimonialAddDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialUpdateDto, Testimonial>().ReverseMap();

            CreateMap<RevisionAddDto, Revision>().ReverseMap();
            CreateMap<RevisionUpdateDto, Revision>().ReverseMap();

            CreateMap<GuestAddDTO, Guest>().ReverseMap();

            CreateMap<AddSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<CreateElevatorDto, Elevator>().ReverseMap();

            CreateMap<ResultOfferDto, Offer>().ReverseMap();
            CreateMap<OfferAddDto, Offer>().ReverseMap();
            CreateMap<OfferUpdateDto, Offer>().ReverseMap();

        }
    }
}
