using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.ServiceDTO;
using ElevatorProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddDto serviceAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Service>(serviceAddDto);
            _serviceService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(ServiceUpdateDto serviceUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Service>(serviceUpdateDto);

            _serviceService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.TGetByID(id);
            return Ok(value);
        }
    }
}
