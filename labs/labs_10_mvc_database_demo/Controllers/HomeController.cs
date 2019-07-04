using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labs_10_mvc_database_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public List<String> myList = new List<String>()
        {
            "a", "b", "c"
        };
        public ActionResult SamsPage()
        {
            return View(myList);
            // <li> @Html.ActionLink("viewable text", "name of method", "object root") </li>
        }
    }
}