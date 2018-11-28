using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeTrackingSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeTrackingSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "The Employee Portal";
            return View();
        }
        public IActionResult Reports()
        {
            ViewData["Message"] = "The Reports page";

            return View();
        }
        public IActionResult Email()
        {
            ViewData["Message"] = "The Email page";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
