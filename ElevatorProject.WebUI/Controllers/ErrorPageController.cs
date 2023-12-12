using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
