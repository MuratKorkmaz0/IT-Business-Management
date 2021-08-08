using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace ITBusinessManagement.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)

        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
