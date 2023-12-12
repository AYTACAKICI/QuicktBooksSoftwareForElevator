using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.DtoLayer.DTOs.BuildingManagerDTO;
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
    public class BuildingManagerController : ControllerBase
    {
        private readonly IBuildingManagerService _buildingManagerService;
        private readonly IMapper _mapper;

        public BuildingManagerController(IBuildingManagerService buildingManagerService, IMapper mapper)
        {
            _buildingManagerService = buildingManagerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BuildingManagerList()
        {
            var values = _buildingManagerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBuildingManager(BuildingManagerAddDto buildingManagerAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<BuildingManager>(buildingManagerAddDto);
            _buildingManagerService.TInsert(values);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBuildingManager(int id)
        {
            var value = _buildingManagerService.TGetByID(id);
            _buildingManagerService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBuildingManager(BuildingManagerUpdateDto buildingManagerUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<BuildingManager>(buildingManagerUpdateDto);

            _buildingManagerService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBuildingManager(int id)
        {
            var value = _buildingManagerService.TGetByID(id);
            return Ok(value);
        }
    }
}
