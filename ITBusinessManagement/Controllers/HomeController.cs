using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITBusinessManagement.Models;

namespace ITBusinessManagement.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult HelpCenter()
        {
            return View();
        }

        public IActionResult TermsOfUse()
        {
            return View();
        }

        public IActionResult Department()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }

        public IActionResult Devices ()
        {
            return View();
        }

        public IActionResult Setting()
        {
            return View();
        }

        public IActionResult Reporting ()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }


        public IActionResult ToDoList ()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult AdvancePayment()
        {
            return View();
        }

        public IActionResult RequirementList()
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
