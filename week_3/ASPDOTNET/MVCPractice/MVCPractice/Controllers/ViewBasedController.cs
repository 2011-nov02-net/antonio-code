﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.Controllers
{
    public class ViewBasedController : Controller
    {
        public IActionResult HomePage()
        {
            return View("home");
        }
    }
}
