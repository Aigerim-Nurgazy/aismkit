﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AisMKIT.Areas.Cinematography.Controllers
{
    [Area("Cinematography")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}