using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebstersPracticalTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Well Come!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us - Websters Covid Violation Fine System";

            return View();
        }
    }
}