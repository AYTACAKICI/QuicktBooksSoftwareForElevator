using ElevatorProject.WebUI.DTOs.MessageCategoryDto;
using ElevatorProject.WebUI.DTOs.OfferDTO;
using ElevatorProject.WebUI.DTOs.ServiceDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class OfferController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OfferController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5066/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                List<SelectListItem> values2 = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.Title,
                                                    Value = x.Title
                                                }).ToList();
                ViewBag.v = values2;

            }
            return View();
                     
        }
        [HttpGet]
        public PartialViewResult AddOfferRequest()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddOfferRequest(AddOfferDto addOfferDto)
        {
            addOfferDto.Status = "Cevap Bekliyor";
            addOfferDto.DateOfRequestForProposal = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addOfferDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
          var response =  await client.PostAsync("https://localhost:44306/api/Offer", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return RedirectToAction("404", "ErrorPage");
           
        }
    
    }
}
