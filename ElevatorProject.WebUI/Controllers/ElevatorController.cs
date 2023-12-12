using ElevatorProject.WebUI.DTOs.BuildingManagerDTO;
using ElevatorProject.WebUI.DTOs.ElevatorDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    public class ElevatorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ElevatorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5066/api/Elevator/ElevatorWithDetails");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultElevatorDto>>(jsondata);
                return View(values);
            }
            return RedirectToAction("Error404", "ErrorPage");
        }

        [HttpGet]
        public IActionResult AddElevator()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddElevator(CreateElevatorDto createElevatorDto)
        {
            if (ModelState.IsValid)
            {
                AddElevatorDto addElevatorDto = new AddElevatorDto()
                {
                    Adress1 = createElevatorDto.Adress1,
                    Adress2 = createElevatorDto.Adress2,
                    Adress3 = createElevatorDto.Adress3,
                    BuildingName = createElevatorDto.BuildingName,
                    Descriptions = createElevatorDto.Descriptions,
                    DoorType = createElevatorDto.DoorType,
                    ElectronicSystemType = createElevatorDto.ElectronicSystemType,
                    ElevatorRegistirationNumber = createElevatorDto.ElevatorRegistirationNumber,
                    ElevatorType = createElevatorDto.ElevatorType,
                    EngineType = createElevatorDto.EngineType,
                    ManufacturedYear = createElevatorDto.ManufacturedYear,
                    Manufacturer = createElevatorDto.Manufacturer,
                    NumberOfFloor = createElevatorDto.NumberOfFloor
                };
                try
                {
                    var client = _httpClientFactory.CreateClient();
                    var jsonData = JsonConvert.SerializeObject(addElevatorDto);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var responseMessage = await client.PostAsync("http://localhost:5066/api/Elevator", stringContent);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var jsondata = await responseMessage.Content.ReadAsStringAsync();
                        var values = JsonConvert.DeserializeObject<CreatedElevatorDto>(jsondata);
                        CreateBuildingManagerDto createBuildingManagerDto = new CreateBuildingManagerDto()
                        {
                            Name = createElevatorDto.Name,
                            Mail = createElevatorDto.Mail,
                            PhoneNumber = createElevatorDto.PhoneNumber,
                            ElevatorID = values.ElevatorID
                        };

                        var client2 = _httpClientFactory.CreateClient();
                        var jsonData2 = JsonConvert.SerializeObject(createBuildingManagerDto);
                        StringContent stringContent2 = new StringContent(jsonData2, Encoding.UTF8, "application/json");
                        var responseMessage2 = await client2.PostAsync("http://localhost:5066/api/BuildingManager", stringContent2);
                        if (responseMessage2.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }

                    }
                    else { return View(); }

                }
                catch (Exception)
                {

                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetElevatorDelete(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5066/api/Elevator/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultElevatorDto>(jsondata);
                return PartialView("_ElevatorDeletePartial", value);
            }

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> DeleteElevator(ResultElevatorDto resultElevator)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5066/api/Elevator/{resultElevator.ElevatorID}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ElevatorUpdate(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5066/api/Elevator/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateElevatorDto>(jsondata);
                return View(value);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ElevatorUpdate(UpdateElevatorDto updateElevator)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(updateElevator);
                StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:5066/api/Elevator/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

            return View();
        }

        public async Task<IActionResult> ElevatorDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5066/api/Elevator/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultElevatorDto>(jsondata);
                return PartialView("_ElevatorDetailPartial", value);

            }
            return RedirectToAction("Error404", "ErrorPage");


        }
    }
}
