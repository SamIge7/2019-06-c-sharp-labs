using My_App_03b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_App_03b.Controllers
{
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User users)
        {
           if(ModelState.IsValid)
            {
                using (DataContext db = new DataContext())
                {
                    var obj = db.Users.Where(u => u.Username.Equals(users.Username) && u.Password.Equals(users.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.UserID.ToString();
                        Session["Username"] = obj.Username.ToString();
                        return RedirectToAction("LoggedIn");
                    }
                }
            }
            return View(users);
        }

        public ActionResult LoggedIn()
        {
            if(Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}