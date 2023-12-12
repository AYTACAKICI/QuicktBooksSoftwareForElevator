using ElevatorProject.WebUI.DTOs.OfferDTO;
using ElevatorProject.WebUI.DTOs.ServiceDTO;
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
    public class AdminOfferController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminOfferController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44306/api/Offer");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultOfferDto>>(jsondata);
                return View(values);
            }
            return RedirectToAction("Error404", "ErrorPage");
        }

        public async Task<IActionResult> OfferDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44306/api/Offer/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultOfferDto>(jsondata);
                return PartialView("_ElevatorDetailPartial", value);

            }
            return RedirectToAction("Error404", "ErrorPage");

        }
        [HttpGet]
        public async Task<IActionResult> GetOfferDelete(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44306/api/Offer/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultOfferDto>(jsondata);
                return PartialView("_OfferDeletePartial", value);
            }

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> DeleteOffer(ResultOfferDto resultOfferDto)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44306/api/Offer?id={resultOfferDto.OfferID}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> OfferUpdate(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5066/api/Offer/{id}");
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5066/api/Service");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);
            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.Title,
                                                Value = x.Title
                                            }).ToList();
            ViewBag.v = values2;
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateOfferDto>(jsondata);
                return View(value);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> OfferUpdate(UpdateOfferDto updateOfferDto)
        {
            if (updateOfferDto.Status != "Cevap Bekleniyor" && updateOfferDto.DateOfSubmitionOfOffer is null)
            {
                updateOfferDto.DateOfSubmitionOfOffer = DateTime.Now;
            }
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(updateOfferDto);
                StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:5066/api/Offer/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

            return View();
        }

    }
}
