using ElevatorProject.EntityLayer.Concrete;
using ElevatorProject.WebUI.DTOs.RegisterDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDTO createNewUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appuser = new AppUser()
            {
                Name = createNewUserDTO.Name,
                Surname = createNewUserDTO.Surname,
                Email = createNewUserDTO.Mail,
                UserName = createNewUserDTO.Username,
                City = createNewUserDTO.City,
                Gender = createNewUserDTO.Gender,
                Country = "Türkiye"
                
            };
            var result = await _userManager.CreateAsync(appuser, createNewUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
