using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.GuestDTO;
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
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;
        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(GuestAddDTO guest)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guest>(guest);
            _guestService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetByID(id);
            _guestService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(GuestAddDTO guest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guest>(guest);
            _guestService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _guestService.TGetByID(id);
            return Ok(value);
        }
    }
}
