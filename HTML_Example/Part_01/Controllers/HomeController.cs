﻿using Microsoft.AspNetCore.Mvc;

namespace Part_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
