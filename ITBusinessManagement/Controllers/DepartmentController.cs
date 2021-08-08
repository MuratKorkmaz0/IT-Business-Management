using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using ITBusinessManagement.Models;

namespace ITBusinessManagement.Controllers
{
    public class DepartmentController : Controller
    {

        public  DepartmentController()
        {
           
        }

        public IActionResult add()
        {
           
            return View();
        }
    }
}
