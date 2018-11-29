using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EmployeeTrackingSystem.Data;
using EmployeeTrackingSystem.Models;

namespace EmployeeTrackingSystem.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _application;
        public AdminController(ApplicationDbContext application)
        {
            _application = application;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewData["Message"] = "Admin";
            return View(_application.Users.ToList());
        }
    }
}