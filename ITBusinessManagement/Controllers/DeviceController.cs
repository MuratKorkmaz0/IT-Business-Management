using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using ITBusinessManagement.Models;

namespace ITBusinessManagement.Controllers
{
    public class DeviceController : Controller
    {
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(ILogger<DeviceController> logger)

        {
            _logger = logger;
        }

        public IActionResult Computer()
        {
            return View();
        }

        public IActionResult Printer()
        {
            return View();
        }

        public IActionResult Ram()
        {
            return View();
        }

        public IActionResult IpPort()
        {
            return View();
        }

        public IActionResult OtherDevice ()
        {
            return View();
        }

        public IActionResult Processor ()
        {
            return View();
        }

        public IActionResult OtherDevices ()
        {
            return View();
        }

        public IActionResult Toner ()
        {
            return View();
        }

        public IActionResult Services ()
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
