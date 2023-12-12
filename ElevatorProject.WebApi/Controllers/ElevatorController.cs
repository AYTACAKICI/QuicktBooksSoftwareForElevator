using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.ElevatorDTO;
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
    public class ElevatorController : ControllerBase
    {
        private readonly IElevatorService _elevatorService;
        private readonly IMapper _mapper;

        public ElevatorController(IElevatorService elevatorService, IMapper mapper)
        {
            _elevatorService = elevatorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ElevatorList()
        {
            var values = _elevatorService.TGetList();
            return Ok(values);
        }
        [HttpGet("ElevatorWithDetails")]
        public async Task<IActionResult> ElevatorWithDetails()
        {
            var values = await _elevatorService.TElevatorDetails();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddElevator(ElevatorAddDto elevatorAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Elevator>(elevatorAddDto);
            var addElevator = _elevatorService.TInsert(values);
            return Ok(addElevator);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteElevator(int id)
        {
            var value = _elevatorService.TGetByID(id);
            _elevatorService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateElevator(ElevatorUpdateDto elevatorUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Elevator>(elevatorUpdateDto);

            _elevatorService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetElevator(int id)
        {
            var value = _elevatorService.TGetByID(id);
            return Ok(value);
        }
    }
}
