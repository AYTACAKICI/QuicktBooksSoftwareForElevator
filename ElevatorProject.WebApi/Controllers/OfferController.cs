using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.OfferDTO;
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
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;
        private readonly IMapper _mapper;

        public OfferController(IOfferService offerService, IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OfferList()
        {
            var values = _offerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddOffer(OfferAddDto offerAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Offer>(offerAddDto);
            _offerService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteOffer(int id)
        {
            var value = _offerService.TGetByID(id);
            _offerService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOffer(OfferUpdateDto offerUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Offer>(offerUpdateDto);

            _offerService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOfferByID(int id)
        {
            var value = _offerService.TGetByID(id);
            return Ok(value);
        }
    }
}
