﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IOptions<Jenkins> options;


        public HomeController(IOptions<Jenkins> _options)
        {
            options = _options;
        }

        public IActionResult Index()
        {
            return View("Index", options.Value.BuildNumber);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
