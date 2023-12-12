using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.PeriodicMaintainceDTO;
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
    public class PeriodicMaintainceController : ControllerBase
    {
        private readonly IPeriodicMaintainceService _periodicMaintainceService;
        private readonly IMapper _mapper;

        public PeriodicMaintainceController(IPeriodicMaintainceService periodicMaintainceService, IMapper mapper)
        {
            _periodicMaintainceService = periodicMaintainceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult PeriodicMaintainceList()
        {
            var values = _periodicMaintainceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddPeriodicMaintaince(PeriodicMaintainceAddDto periodicMaintainceAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<PeriodicMaintaince>(periodicMaintainceAddDto);
            _periodicMaintainceService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeletePeriodicMaintaince(int id)
        {
            var value = _periodicMaintainceService.TGetByID(id);
            _periodicMaintainceService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePeriodicMaintaince(PeriodicMaintainceUpdateDto periodicMaintainceUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<PeriodicMaintaince>(periodicMaintainceUpdateDto);

            _periodicMaintainceService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPeriodicMaintaince(int id)
        {
            var value = _periodicMaintainceService.TGetByID(id);
            return Ok(value);
        }
    }
}
