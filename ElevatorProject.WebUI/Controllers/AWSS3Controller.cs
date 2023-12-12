using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    public class AWSS3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
