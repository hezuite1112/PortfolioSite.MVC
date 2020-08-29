using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Porfolio.Models;
using System.Net.Mail;

namespace Porfolio.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SendEmail(string To, string Body, string Subject)
        {
            MailMessage mm = new MailMessage();
            mm.To.Add(To);
            mm.To.Add("jakub.pawelec1112@gmail.com");
            mm.Subject = Subject;
            mm.Body = Body;
            mm.From = new MailAddress("smtp.pawelec@gmail.com");
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = true,
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential("smtp.pawelec@gmail.com", "Hezuite111@")
            };

            smtp.Send(mm);
            ViewBag.message = "The Mail Has Been Send Successfully!";
            return new JsonResult("Mail has been sent! Receiving a copy confirms that the message has been sent.");
        }
    }
}
