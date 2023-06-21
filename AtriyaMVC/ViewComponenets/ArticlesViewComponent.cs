using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtriyaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtriyaMVC.ViewComponenets
{
    public class ArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>()
            {
                new Article(1, "MVC", "جدید ترین تغییرات دات نت 7 به همراه اموزش", "blog-post-thumb-card-1.jpg", "Microsoft"),
                new Article(1, "JavaScript", "جدید ترین تغییرات و قانون های اکما اسکریپت و قانون های جدید", "blog-post-thumb-card-2.jpg",
                    "EcmaCompany"),
                new Article(1, "Kotlien", "چه مزایای کاتلین را از جاوا بهتر میکند", "blog-post-thumb-card-3.jpg", "google"),
            };

            return View("_Articles",Articles);
        }
    }
}
