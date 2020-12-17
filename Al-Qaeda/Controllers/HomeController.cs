using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Al_Qaeda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            Models.Human HR = new Models.Human();
            HR.FIO = ("Иванов Иван Иванович");
            Models.Work FirstWork= new Models.Work();
            FirstWork.Name = "Чебуречная";
            int year = date.Year;
            int month = date.Month;
            ViewBag.Exp = date;
            ViewBag.Ex = year;
            ViewBag.E = month;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}