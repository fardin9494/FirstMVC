using AtriyaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AtriyaMVC.Controllers
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
        [HttpGet]
        public IActionResult Contact()
        {
            ContactForm Contact = new ContactForm();
            return View(Contact);
        }


        [HttpPost]
        public IActionResult Contact(ContactForm Form)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.Error = "اطلاعات شما صحیح نمیباشد";
                return View(Form);
            }
            else
            {
                ViewBag.success = "اطلاعات با موفقیت ثبت شد";
                return View();
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
