using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.AboutDTO;
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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(AboutAddDto aboutAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<About>(aboutAddDto);
            _aboutService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(AboutUpdateDto aboutUpdateDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<About>(aboutUpdateDto);
            _aboutService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
