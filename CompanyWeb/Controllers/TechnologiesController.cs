using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Controllers
{
    public class TechnologiesController : Controller
    {
        // GET: Technologies
        public ActionResult Index()
        {
            return View();
        }
    }
}