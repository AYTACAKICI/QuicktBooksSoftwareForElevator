using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.StaffDTO;
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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(StaffAddDto staffAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Staff>(staffAddDto);
            _staffService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.TGetByID(id);
            _staffService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(StaffUpdateDto staffUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Staff>(staffUpdateDto);

            _staffService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var value = _staffService.TGetByID(id);
            return Ok(value);
        }
    }
}
