﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class AboutUseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
