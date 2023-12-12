using AutoMapper;
using ElevatorProject.BusinessLayer.Abstract;
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
    public class SendMessageController : ControllerBase
    {

        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper  _mapper ;

        public SendMessageController(ISendMessageService sendMessageService,IMapper mapper)
        {
            _sendMessageService = sendMessageService;
        _mapper= mapper;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SendMessage>(sendMessage);
            _sendMessageService.TInsert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var value = _sendMessageService.TGetByID(id);
            _sendMessageService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SendMessage>(sendMessage);
            _sendMessageService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var value = _sendMessageService.TGetByID(id);
            return Ok(value);
        }
        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            return Ok(_sendMessageService.TGetSendMessageCount());
        }

    }
}
