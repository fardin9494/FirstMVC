using AtriyaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AtriyaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Services> servicesList = new List<Services>()
        {
            new Services(1, "نقره ای"),
            new Services(2, "طلایی"),
            new Services(3, "پلاتین"),
            new Services(4, "الماس")
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ContactForm Contact = new ContactForm()
            {
                ServiceList = new SelectList(servicesList,"Id","Value")
            };
            return View(Contact);
        }


        [HttpPost]
        public IActionResult Contact(ContactForm Form)
        {
            Form.ServiceList = new SelectList(servicesList, "Id", "Value");

            if (ModelState.IsValid == false)
            {
                ViewBag.Error = "اطلاعات شما صحیح نمیباشد";
                return View(Form);
            }
            else
            {
                ModelState.Clear();
                ContactForm Contact = new ContactForm()
                {
                    ServiceList = new SelectList(servicesList,"Id","Value")
                };

                ViewBag.success = "اطلاعات با موفقیت ثبت شد";
                return View(Contact);
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
