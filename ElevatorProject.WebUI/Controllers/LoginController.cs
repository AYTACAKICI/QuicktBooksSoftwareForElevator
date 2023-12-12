using ElevatorProject.EntityLayer.Concrete;
using ElevatorProject.WebUI.DTOs.LoginDTO;
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
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDTO loginUserDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginUserDTO.Username, loginUserDTO.Password, false, false);
                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Elevator");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
