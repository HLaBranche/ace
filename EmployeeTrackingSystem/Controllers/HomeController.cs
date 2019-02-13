using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeTrackingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mail;

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

        //[HttpPost]
        //public ActionResult Email(EmployeeTrackingSystem.Models.EmailModel model)
        //{
        //    MailMessage message = new MailMessage("huntsville37@gmail.com", model.To);
        //    message.Subject = model.Subject;
        //    message.Body = model.Body;
        //    message.IsBodyHtml = false;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    //smtp.Host = "smtp.yahoo.com";
        //    //smtp.Host = "smtp.outlook.com";
        //    smtp.Port = 587;
        //    smtp.EnableSsl = true;



        //    smtp.UseDefaultCredentials = true;
        //    smtp.Credentials = new System.Net.NetworkCredential("huntsville37@gmail.com", "password");
        //    smtp.Send(message);
        //    ViewBag.Message = "message sent";
        //    return View();

        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
