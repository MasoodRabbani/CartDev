using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCart_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCart_MVC.ViewComponent
{
    public class ArticelViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articel = new List<Articel>()
            {
                new Articel(1,"Asp.net core MVC","کامل ترین پکیج اموزش Asp.net core MVC به زبان فارسی","blog-post-thumb-1.jpg"),
                new Articel(2,"javascript","کامل ترین پکیج اموزش javascript به زبان فارسی","blog-post-thumb-2.jpg"),
                new Articel(3,"React","کامل ترین پکیج اموزش React به زبان فارسی","blog-post-thumb-3.jpg"),
                new Articel(4,"ICDL","کامل ترین پکیج اموزش ICDL به زبان فارسی","blog-post-thumb-4.jpg"),
                new Articel(5,"NodeJs","کامل ترین پکیج اموزش NodeJs به زبان فارسی","blog-post-thumb-5.jpg"),
                new Articel(6,"A++","کامل ترین پکیج اموزش A++ به زبان فارسی","blog-post-thumb-6.jpg")
            };
            return View("_Articel", articel);
        }
    }
}
