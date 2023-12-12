using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.BreakdownRecordDTO;
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
    public class BreakdownRecordController : ControllerBase
    {
        private readonly IBreakdownRecordService _breakdownRecordService;
        private readonly IMapper _mapper;

        public BreakdownRecordController(IBreakdownRecordService breakdownRecordService, IMapper mapper)
        {
            _breakdownRecordService = breakdownRecordService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BreakdownRecordList()
        {
            var values = _breakdownRecordService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBreakdownRecord(BreakdownRecordAddDTO breakdownRecordAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<BreakdownRecord>(breakdownRecordAdd);
            _breakdownRecordService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBreakdownRecord(int id)
        {
            var value = _breakdownRecordService.TGetByID(id);
            _breakdownRecordService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBreakdownRecord(BreakdownRecordUpdateDto breakdownRecordUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<BreakdownRecord>(breakdownRecordUpdateDto);

            _breakdownRecordService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBreakdownRecord(int id)
        {
            var value = _breakdownRecordService.TGetByID(id);
            return Ok(value);
        }
    }
}
