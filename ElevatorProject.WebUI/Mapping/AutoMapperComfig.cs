using AutoMapper;
using ElevatorProject.EntityLayer.Concrete;
using ElevatorProject.WebUI.DTOs.AboutDTO;
using ElevatorProject.WebUI.DTOs.ElevatorDTO;
using ElevatorProject.WebUI.DTOs.GuestDTO;
using ElevatorProject.WebUI.DTOs.LoginDTO;
using ElevatorProject.WebUI.DTOs.OfferDTO;
using ElevatorProject.WebUI.DTOs.RegisterDTO;
using ElevatorProject.WebUI.DTOs.ServiceDTO;
using ElevatorProject.WebUI.DTOs.StaffDTO;
using ElevatorProject.WebUI.DTOs.TestimonialDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Mapping
{
    public class AutoMapperComfig : Profile
    {
        public AutoMapperComfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();

            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();


            CreateMap<ResultStaffDto, Staff>().ReverseMap();

          

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<CreateElevatorDto, Elevator>().ReverseMap();

            CreateMap<AddOfferDto, Offer>().ReverseMap();
            CreateMap<ResultOfferDto, Offer>().ReverseMap();
            CreateMap<UpdateOfferDto, Offer>().ReverseMap();
        }
    }
}
