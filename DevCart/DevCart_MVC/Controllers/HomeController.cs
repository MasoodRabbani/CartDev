using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevCart_MVC.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCart_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public FileResult DM()
        {
            return File("~/test.txt","text/html");
        }

        public JsonResult Test()
        {
            var model = new {name = "masood", family = "rabbani", phonenumber = "09016319519"};
            return Json(model);
        }

        public IActionResult Contact()
        {
            //Dictionary<int, string> model = new Dictionary<int, string>()
            //{
            //    {1, "الماس"},
            //    {2, "پلاتین"},
            //    {3, "نقره ای"}
            //};//{1,"نقره ای ",2, "پلاتین",3, "الماس",4, "الماس"};
            //ViewBag.listmodel = new SelectList(model,model.Keys);
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
