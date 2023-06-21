using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtriyaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtriyaMVC.ViewComponenets
{
    public class ProjectViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> Allr = new List<Project>()
            {
                new Project(1, "zoodfood", "ارسال غذایه گرم به کل ایران در چند ثانیه", "project-1.jpg", "Snapfood"),
                new Project(2, "googiran", "موتور جستجو ایرانی فوق العاده ", "project-2.jpg", "google"),
                new Project(3, "Amozino", "اموزش به سبک دوست دختر پشمالوا در 20 ثانیه", "project-3.jpg", "DDpFerfozhe"),
                new Project(4, "SagDost", "اموزش و خرید و فروش انواع حیووانات خانگی مخصوصا سگ", "project-4.jpg", "unisef")
            };
            return View("_Projects",Allr);
        }
    }
}
