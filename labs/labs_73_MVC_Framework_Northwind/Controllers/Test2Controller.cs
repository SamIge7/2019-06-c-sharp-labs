using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labs_73_MVC_Framework_Northwind.Controllers
{
    public class Test2Controller : Controller
    {
        // GET: Test2
        public ActionResult Index()
        {
            return View("Cricket");
        }

        public ActionResult Golf()
        {
            return View();
        }

        public ActionResult Cricket()
        {
            return View();
        }
    }
}