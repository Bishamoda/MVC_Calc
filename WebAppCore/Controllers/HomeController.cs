using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.Models;

namespace WebAppCore.Controllers
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
        [HttpPost]
        public IActionResult Index(Calculation calc)
        {
            ViewData["Number1"] = calc.Number1;
            ViewData["Number2"] = calc.Number2;

            switch (calc.Op)
            {
                case '+':
                    calc.Result = calc.Number1 + calc.Number2;
                    break;

                case '-':
                    calc.Result = calc.Number1 - calc.Number2;
                    break;

                case '*':
                    calc.Result = calc.Number1 * calc.Number2;
                    break;

                case '/':
                    if (calc.Number2 != 0)
                    {
                        calc.Result = calc.Number1 / calc.Number2;
                    }
                    else
                    {
                        calc.Result = 0;
                        calc.Number1 = 0;
                        calc.Number2 = 0;
                        ViewData["Number2"] = calc.Number2;

                    }
                    break;

                case 'c':
                    calc.Result = 0;
                    calc.Number1 = 0;
                    calc.Number2 = 0;
                    ViewData["Number2"] = calc.Number2;
                    break;

            }

            ViewData["Result"] = calc.Result;
            
            calc.Number1 = calc.Result;

            ViewData["Number1"] = calc.Number1;
            return View(calc);
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
