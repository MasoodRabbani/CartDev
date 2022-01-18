using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCart_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCart_MVC.ViewComponent
{
    public class ProjectViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>()
            {
                new Project(1, "پروژه اسنپ", "اسنپ یک تاکسی اینترنتی هوشمند است", "project-1.jpg", "snap"),
                new Project(2, "پروژه هوافضا", "برای مدیریت حوادث هوایی و رویاداد های فضایی", "project-2.jpg", "nasa"),
                new Project(3, "پروژه گوگل", "موتور جستو جو گر پیشرفته ", "project-3.jpg", "google"),
                new Project(4, "پروژه اینستا", "شبکه اجتماعی و اخبرای برای عموم", "project-4.jpg", "facebook"),
                new Project(5, "پروژه تلگرام", "شبکه اجتماعی و پیام رسانی قدرت مند با رایانش ابری ", "project-5.jpg","Telegram")

            };
            return View("_Project",project);
        }
    }
}
