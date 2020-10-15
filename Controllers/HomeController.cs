using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Second_MVC_Project.Models;

namespace Second_MVC_Project.Controllers
{
    namespace Initial_MVC_Project.Controllers
    {
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Code()
            {
                return View();
            }
            [HttpGet]
            public IActionResult Solve()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Solve(string input1, string input2)
            {
                var startNum = Convert.ToInt32(input1);
                var endNum = Convert.ToInt32(input2);
                var output = new StringBuilder();
                for (var index = startNum; index <= endNum; index++)
                {
                    output.AppendLine(index.ToString());
                }

                ViewData["Output"] = output.ToString();
                return View();
            }


            public IActionResult Test()
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