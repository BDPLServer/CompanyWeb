using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our Company Mission";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact page.";
            
            return View();
        }
       
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Our Company Portfolio";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Our Products";

            return View();
        }
    }
}