using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.RevisionDTO;
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
    public class RevisionController : ControllerBase
    {
        private readonly IRevisionService _revisionService;
        private readonly IMapper _mapper;

        public RevisionController(IRevisionService revisionService, IMapper mapper)
        {
            _revisionService = revisionService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RevisionList()
        {
            var values = _revisionService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRevision(RevisionAddDto revisionAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Revision>(revisionAddDto);
            _revisionService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRevision(int id)
        {
            var value = _revisionService.TGetByID(id);
            _revisionService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRevision(RevisionUpdateDto revisionUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Revision>(revisionUpdateDto);

            _revisionService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRevision(int id)
        {
            var value = _revisionService.TGetByID(id);
            return Ok(value);
        }
    }
}
