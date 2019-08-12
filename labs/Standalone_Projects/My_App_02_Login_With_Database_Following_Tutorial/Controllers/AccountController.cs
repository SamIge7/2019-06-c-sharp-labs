using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Sitecore.FakeDb;
using EO.Internal;

namespace My_App_02_Login_With_Database_Following_Tutorial.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Validate(Admins admin)
        {
            var _admin = db.Admins.Where(s => s.E)
        }
    }
}